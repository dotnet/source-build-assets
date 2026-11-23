// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.Extensions.Caching.Memory.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f33a29044fa9d740c9b3213a93e57c84b472c84e0b8a0e1ae48e67a9f8f6de9d5f7f3d52ac23e48ac51801f1dc950abe901da34d2a9e3baadb141a17c77ef3c565dd5ee5054b91cf63bb3c6ab83f72ab3aafe93d0fc3c2348b764fafb0b1c0733de51459aeab46580384bf9d74c4e28164b7cde247f891ba07891c9d872ad2bb")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v10.0", FrameworkDisplayName = ".NET 10.0")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyDefaultAlias("Microsoft.Extensions.Caching.Memory")]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
[assembly: System.Reflection.AssemblyMetadata("IsAotCompatible", "True")]
[assembly: System.Runtime.InteropServices.DefaultDllImportSearchPaths(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("In-memory cache implementation of Microsoft.Extensions.Caching.Memory.IMemoryCache.")]
[assembly: System.Reflection.AssemblyFileVersion("10.0.25.52411")]
[assembly: System.Reflection.AssemblyInformationalVersion("10.0.0+b0f34d51fccc69fd334253924abd8d6853fad7aa")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET")]
[assembly: System.Reflection.AssemblyTitle("Microsoft.Extensions.Caching.Memory")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/dotnet/dotnet")]
[assembly: System.Reflection.AssemblyVersionAttribute("10.0.0.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Microsoft.Extensions.Caching.Distributed
{
    public partial class MemoryDistributedCache : IDistributedCache
    {
        public MemoryDistributedCache(Options.IOptions<Memory.MemoryDistributedCacheOptions> optionsAccessor, Logging.ILoggerFactory loggerFactory) { }
        public MemoryDistributedCache(Options.IOptions<Memory.MemoryDistributedCacheOptions> optionsAccessor) { }
        public byte[]? Get(string key) { throw null; }
        public System.Threading.Tasks.Task<byte[]?> GetAsync(string key, System.Threading.CancellationToken token = default) { throw null; }
        public void Refresh(string key) { }
        public System.Threading.Tasks.Task RefreshAsync(string key, System.Threading.CancellationToken token = default) { throw null; }
        public void Remove(string key) { }
        public System.Threading.Tasks.Task RemoveAsync(string key, System.Threading.CancellationToken token = default) { throw null; }
        public void Set(string key, byte[] value, DistributedCacheEntryOptions options) { }
        public System.Threading.Tasks.Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, System.Threading.CancellationToken token = default) { throw null; }
    }
}

namespace Microsoft.Extensions.Caching.Memory
{
    public partial class MemoryCache : IMemoryCache, System.IDisposable
    {
        public MemoryCache(Options.IOptions<MemoryCacheOptions> optionsAccessor, Logging.ILoggerFactory loggerFactory) { }
        public MemoryCache(Options.IOptions<MemoryCacheOptions> optionsAccessor) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.IEnumerable<object> Keys { get { throw null; } }
        public void Clear() { }
        public void Compact(double percentage) { }
        public ICacheEntry CreateEntry(object key) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~MemoryCache() {
        }
        public MemoryCacheStatistics? GetCurrentStatistics() { throw null; }
        public void Remove(object key) { }
        public bool TryGetValue(object key, out object? result) { throw null; }
        [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
        public bool TryGetValue(System.ReadOnlySpan<char> key, out object? value) { throw null; }
        [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
        public bool TryGetValue<TItem>(System.ReadOnlySpan<char> key, out TItem? value) { throw null; }
    }

    public partial class MemoryCacheOptions : Options.IOptions<MemoryCacheOptions>
    {
        public Internal.ISystemClock? Clock { get { throw null; } set { } }
        public double CompactionPercentage { get { throw null; } set { } }
        [System.Obsolete("This property is retained only for compatibility.  Remove use and instead call MemoryCache.Compact as needed.", true)]
        public bool CompactOnMemoryPressure { get { throw null; } set { } }
        public System.TimeSpan ExpirationScanFrequency { get { throw null; } set { } }
        MemoryCacheOptions Options.IOptions<MemoryCacheOptions>.Value { get { throw null; } }
        public long? SizeLimit { get { throw null; } set { } }
        public bool TrackLinkedCacheEntries { get { throw null; } set { } }
        public bool TrackStatistics { get { throw null; } set { } }
    }

    public partial class MemoryDistributedCacheOptions : MemoryCacheOptions
    {
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class MemoryCacheServiceCollectionExtensions
    {
        public static IServiceCollection AddDistributedMemoryCache(this IServiceCollection services, System.Action<Caching.Memory.MemoryDistributedCacheOptions> setupAction) { throw null; }
        public static IServiceCollection AddDistributedMemoryCache(this IServiceCollection services) { throw null; }
        public static IServiceCollection AddMemoryCache(this IServiceCollection services, System.Action<Caching.Memory.MemoryCacheOptions> setupAction) { throw null; }
        public static IServiceCollection AddMemoryCache(this IServiceCollection services) { throw null; }
    }
}