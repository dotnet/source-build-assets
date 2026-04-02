# .NET Source Build Reference Packages - Copilot Instructions

This file contains AI-specific guidance for working with this repository.
All general documentation is maintained in the [README.md](../README.md) to avoid duplication.

## Critical Safety Rules

### Absolute Prohibitions

- **NEVER** modify files inside `src/externalPackages/src/` (these are git submodules)
- **NEVER** delete or recreate `Customizations.props` or `Customizations.cs` files
- **NEVER** suggest adding preview/RC packages
- **NEVER** ignore build failures in `./build.sh -sb`

### Before Making Changes

- **ALWAYS** check if a package has existing customizations before regenerating
- **ALWAYS** validate commands work on Linux (primary platform for source-build)
- **ALWAYS** preserve intentional code comments explaining manual fixes

## Workflow Patterns

### When User Asks to "Add a Package"

1. Determine package type first: External, Reference, Targeting, or Text-only
2. For Reference packages: Use `./generate.sh --package name,version`
3. For External packages: Requires submodule + project creation + patches1
4. Check README for detailed workflows

### When Regenerating Packages

```bash
# Check for existing customizations first
find src/referencePackages/src/package.name/version -name "Customizations.*"
```

- If customizations exist, preserve them during regeneration
- The generate script will preserve them

### When Build Fails

1. Try building individual package: `./build.sh -sb --projects /full/path/to/package.csproj`
2. Check for compilation errors that need `Customizations.props` (NoWarn entries)
3. Look for API issues that need `Customizations.cs` (partial class additions)
4. Always add explanatory comments for manual fixes needed in the generated source files outside of Customizations files

## Decision Support

### Customizations.props vs Customizations.cs

- **Customizations.props**: MSBuild properties, NoWarn suppressions, additional source files
- **Customizations.cs**: Additional types, members for partial classes, conditional compilation

### External Package Changes

- Always create patches via `extract-patches.sh` - never suggest direct file edits
- Patches live in `src/externalPackages/patches/<component>/`
- Test patches with `git am` before suggesting

#### Patch Minimization Principles

- **Push behavior to the `.proj` file first.** Many build behaviors (disabling analyzers, NuGet audit,
  code-style enforcement, version overrides, TFM restrictions) can be controlled via `/p:` arguments
  in the [project file](../src/externalPackages/projects). Check if the upstream repo already defines
  an MSBuild property before patching (e.g. `SkipAnalysis`, `IntegrationBuild`, `EnablePublicApi`).
- **Use MSBuild conditions, not deletions.** When a patch is necessary, add a `Condition` attribute
  (e.g. `Condition="'$(DotNetBuildSourceOnly)' != 'true'"`) instead of removing the XML element.
  This produces smaller diffs and is potentially upstreamable.
- **Keep CPM enabled.** If the upstream project uses Central Package Management, do not disable it.
  Instead, update version pins in `Directory.Packages.props` using a source-build condition block
  to align with versions available in SBRP.

## Validation Checklist

After any package changes:

- [ ] `./build.sh -sb` succeeds
- [ ] Check `artifacts/packages/*` for expected output
- [ ] Verify no new files in submodule directories
- [ ] Confirm Customizations files preserved if they existed

## 🔗 References

- All build commands and detailed processes are in the [README.md](../README.md)
- Generator issues: [docs/known_generator_issues.md](../docs/known_generator_issues.md)
