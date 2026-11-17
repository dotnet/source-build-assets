// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v10.0", FrameworkDisplayName = ".NET 10.0")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyDefaultAlias("Microsoft.Extensions.Caching.Abstractions")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
[assembly: System.Reflection.AssemblyMetadata("IsAotCompatible", "True")]
[assembly: System.Runtime.InteropServices.DefaultDllImportSearchPaths(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("Caching abstractions for in-memory cache and distributed cache.\r\n\r\nCommonly Used Types:\r\nMicrosoft.Extensions.Caching.Distributed.IDistributedCache\r\nMicrosoft.Extensions.Caching.Memory.IMemoryCache")]
[assembly: System.Reflection.AssemblyFileVersion("10.0.25.52411")]
[assembly: System.Reflection.AssemblyInformationalVersion("10.0.0+b0f34d51fccc69fd334253924abd8d6853fad7aa")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET")]
[assembly: System.Reflection.AssemblyTitle("Microsoft.Extensions.Caching.Abstractions")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/dotnet/dotnet")]
[assembly: System.Reflection.AssemblyVersionAttribute("10.0.0.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsExternalInit))]
namespace Microsoft.Extensions.Caching.Distributed
{
    public static partial class DistributedCacheEntryExtensions
    {
        public static DistributedCacheEntryOptions SetAbsoluteExpiration(this DistributedCacheEntryOptions options, System.DateTimeOffset absolute) { throw null; }
        public static DistributedCacheEntryOptions SetAbsoluteExpiration(this DistributedCacheEntryOptions options, System.TimeSpan relative) { throw null; }
        public static DistributedCacheEntryOptions SetSlidingExpiration(this DistributedCacheEntryOptions options, System.TimeSpan offset) { throw null; }
    }

    public partial class DistributedCacheEntryOptions
    {
        public System.DateTimeOffset? AbsoluteExpiration { get { throw null; } set { } }
        public System.TimeSpan? AbsoluteExpirationRelativeToNow { get { throw null; } set { } }
        public System.TimeSpan? SlidingExpiration { get { throw null; } set { } }
    }

    public static partial class DistributedCacheExtensions
    {
        public static string? GetString(this IDistributedCache cache, string key) { throw null; }
        public static System.Threading.Tasks.Task<string?> GetStringAsync(this IDistributedCache cache, string key, System.Threading.CancellationToken token = default) { throw null; }
        public static void Set(this IDistributedCache cache, string key, byte[] value) { }
        public static System.Threading.Tasks.Task SetAsync(this IDistributedCache cache, string key, byte[] value, System.Threading.CancellationToken token = default) { throw null; }
        public static void SetString(this IDistributedCache cache, string key, string value, DistributedCacheEntryOptions options) { }
        public static void SetString(this IDistributedCache cache, string key, string value) { }
        public static System.Threading.Tasks.Task SetStringAsync(this IDistributedCache cache, string key, string value, DistributedCacheEntryOptions options, System.Threading.CancellationToken token = default) { throw null; }
        public static System.Threading.Tasks.Task SetStringAsync(this IDistributedCache cache, string key, string value, System.Threading.CancellationToken token = default) { throw null; }
    }

    public partial interface IBufferDistributedCache : IDistributedCache
    {
        void Set(string key, System.Buffers.ReadOnlySequence<byte> value, DistributedCacheEntryOptions options);
        System.Threading.Tasks.ValueTask SetAsync(string key, System.Buffers.ReadOnlySequence<byte> value, DistributedCacheEntryOptions options, System.Threading.CancellationToken token = default);
        bool TryGet(string key, System.Buffers.IBufferWriter<byte> destination);
        System.Threading.Tasks.ValueTask<bool> TryGetAsync(string key, System.Buffers.IBufferWriter<byte> destination, System.Threading.CancellationToken token = default);
    }

    public partial interface IDistributedCache
    {
        byte[]? Get(string key);
        System.Threading.Tasks.Task<byte[]?> GetAsync(string key, System.Threading.CancellationToken token = default);
        void Refresh(string key);
        System.Threading.Tasks.Task RefreshAsync(string key, System.Threading.CancellationToken token = default);
        void Remove(string key);
        System.Threading.Tasks.Task RemoveAsync(string key, System.Threading.CancellationToken token = default);
        void Set(string key, byte[] value, DistributedCacheEntryOptions options);
        System.Threading.Tasks.Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, System.Threading.CancellationToken token = default);
    }
}

namespace Microsoft.Extensions.Caching.Hybrid
{
    public abstract partial class HybridCache
    {
        public System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<T>(System.ReadOnlySpan<char> key, System.Func<System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<T>(ref System.Runtime.CompilerServices.DefaultInterpolatedStringHandler key, System.Func<System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<T>(string key, System.Func<System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public virtual System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<TState, T>(System.ReadOnlySpan<char> key, TState state, System.Func<TState, System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<TState, T>(ref System.Runtime.CompilerServices.DefaultInterpolatedStringHandler key, TState state, System.Func<TState, System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public abstract System.Threading.Tasks.ValueTask<T> GetOrCreateAsync<TState, T>(string key, TState state, System.Func<TState, System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<T>> factory, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default);
        public virtual System.Threading.Tasks.ValueTask RemoveAsync(System.Collections.Generic.IEnumerable<string> keys, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public abstract System.Threading.Tasks.ValueTask RemoveAsync(string key, System.Threading.CancellationToken cancellationToken = default);
        public virtual System.Threading.Tasks.ValueTask RemoveByTagAsync(System.Collections.Generic.IEnumerable<string> tags, System.Threading.CancellationToken cancellationToken = default) { throw null; }
        public abstract System.Threading.Tasks.ValueTask RemoveByTagAsync(string tag, System.Threading.CancellationToken cancellationToken = default);
        public abstract System.Threading.Tasks.ValueTask SetAsync<T>(string key, T value, HybridCacheEntryOptions? options = null, System.Collections.Generic.IEnumerable<string>? tags = null, System.Threading.CancellationToken cancellationToken = default);
    }

    [System.Flags]
    public enum HybridCacheEntryFlags
    {
        None = 0,
        DisableLocalCacheRead = 1,
        DisableLocalCacheWrite = 2,
        DisableLocalCache = 3,
        DisableDistributedCacheRead = 4,
        DisableDistributedCacheWrite = 8,
        DisableDistributedCache = 12,
        DisableUnderlyingData = 16,
        DisableCompression = 32
    }

    public sealed partial class HybridCacheEntryOptions
    {
        public System.TimeSpan? Expiration { get { throw null; } init { } }
        public HybridCacheEntryFlags? Flags { get { throw null; } init { } }
        public System.TimeSpan? LocalCacheExpiration { get { throw null; } init { } }
    }

    public partial interface IHybridCacheSerializerFactory
    {
        bool TryCreateSerializer<T>(out IHybridCacheSerializer<T>? serializer);
    }

    public partial interface IHybridCacheSerializer<T>
    {
        T Deserialize(System.Buffers.ReadOnlySequence<byte> source);
        void Serialize(T value, System.Buffers.IBufferWriter<byte> target);
    }
}

namespace Microsoft.Extensions.Caching.Memory
{
    public static partial class CacheEntryExtensions
    {
        public static ICacheEntry AddExpirationToken(this ICacheEntry entry, Primitives.IChangeToken expirationToken) { throw null; }
        public static ICacheEntry RegisterPostEvictionCallback(this ICacheEntry entry, PostEvictionDelegate callback, object? state) { throw null; }
        public static ICacheEntry RegisterPostEvictionCallback(this ICacheEntry entry, PostEvictionDelegate callback) { throw null; }
        public static ICacheEntry SetAbsoluteExpiration(this ICacheEntry entry, System.DateTimeOffset absolute) { throw null; }
        public static ICacheEntry SetAbsoluteExpiration(this ICacheEntry entry, System.TimeSpan relative) { throw null; }
        public static ICacheEntry SetOptions(this ICacheEntry entry, MemoryCacheEntryOptions options) { throw null; }
        public static ICacheEntry SetPriority(this ICacheEntry entry, CacheItemPriority priority) { throw null; }
        public static ICacheEntry SetSize(this ICacheEntry entry, long size) { throw null; }
        public static ICacheEntry SetSlidingExpiration(this ICacheEntry entry, System.TimeSpan offset) { throw null; }
        public static ICacheEntry SetValue(this ICacheEntry entry, object? value) { throw null; }
    }

    public static partial class CacheExtensions
    {
        public static object? Get(this IMemoryCache cache, object key) { throw null; }
        public static TItem? Get<TItem>(this IMemoryCache cache, object key) { throw null; }
        public static TItem? GetOrCreate<TItem>(this IMemoryCache cache, object key, System.Func<ICacheEntry, TItem> factory, MemoryCacheEntryOptions? createOptions) { throw null; }
        public static TItem? GetOrCreate<TItem>(this IMemoryCache cache, object key, System.Func<ICacheEntry, TItem> factory) { throw null; }
        public static System.Threading.Tasks.Task<TItem?> GetOrCreateAsync<TItem>(this IMemoryCache cache, object key, System.Func<ICacheEntry, System.Threading.Tasks.Task<TItem>> factory, MemoryCacheEntryOptions? createOptions) { throw null; }
        public static System.Threading.Tasks.Task<TItem?> GetOrCreateAsync<TItem>(this IMemoryCache cache, object key, System.Func<ICacheEntry, System.Threading.Tasks.Task<TItem>> factory) { throw null; }
        public static TItem Set<TItem>(this IMemoryCache cache, object key, TItem value, MemoryCacheEntryOptions? options) { throw null; }
        public static TItem Set<TItem>(this IMemoryCache cache, object key, TItem value, Primitives.IChangeToken expirationToken) { throw null; }
        public static TItem Set<TItem>(this IMemoryCache cache, object key, TItem value, System.DateTimeOffset absoluteExpiration) { throw null; }
        public static TItem Set<TItem>(this IMemoryCache cache, object key, TItem value, System.TimeSpan absoluteExpirationRelativeToNow) { throw null; }
        public static TItem Set<TItem>(this IMemoryCache cache, object key, TItem value) { throw null; }
        public static bool TryGetValue<TItem>(this IMemoryCache cache, object key, out TItem? value) { throw null; }
    }

    public enum CacheItemPriority
    {
        Low = 0,
        Normal = 1,
        High = 2,
        NeverRemove = 3
    }

    public enum EvictionReason
    {
        None = 0,
        Removed = 1,
        Replaced = 2,
        Expired = 3,
        TokenExpired = 4,
        Capacity = 5
    }

    public partial interface ICacheEntry : System.IDisposable
    {
        System.DateTimeOffset? AbsoluteExpiration { get; set; }
        System.TimeSpan? AbsoluteExpirationRelativeToNow { get; set; }
        System.Collections.Generic.IList<Primitives.IChangeToken> ExpirationTokens { get; }
        object Key { get; }
        System.Collections.Generic.IList<PostEvictionCallbackRegistration> PostEvictionCallbacks { get; }
        CacheItemPriority Priority { get; set; }
        long? Size { get; set; }
        System.TimeSpan? SlidingExpiration { get; set; }
        object? Value { get; set; }
    }

    public partial interface IMemoryCache : System.IDisposable
    {
        ICacheEntry CreateEntry(object key);
        MemoryCacheStatistics? GetCurrentStatistics();
        void Remove(object key);
        bool TryGetValue(object key, out object? value);
    }

    public static partial class MemoryCacheEntryExtensions
    {
        public static MemoryCacheEntryOptions AddExpirationToken(this MemoryCacheEntryOptions options, Primitives.IChangeToken expirationToken) { throw null; }
        public static MemoryCacheEntryOptions RegisterPostEvictionCallback(this MemoryCacheEntryOptions options, PostEvictionDelegate callback, object? state) { throw null; }
        public static MemoryCacheEntryOptions RegisterPostEvictionCallback(this MemoryCacheEntryOptions options, PostEvictionDelegate callback) { throw null; }
        public static MemoryCacheEntryOptions SetAbsoluteExpiration(this MemoryCacheEntryOptions options, System.DateTimeOffset absolute) { throw null; }
        public static MemoryCacheEntryOptions SetAbsoluteExpiration(this MemoryCacheEntryOptions options, System.TimeSpan relative) { throw null; }
        public static MemoryCacheEntryOptions SetPriority(this MemoryCacheEntryOptions options, CacheItemPriority priority) { throw null; }
        public static MemoryCacheEntryOptions SetSize(this MemoryCacheEntryOptions options, long size) { throw null; }
        public static MemoryCacheEntryOptions SetSlidingExpiration(this MemoryCacheEntryOptions options, System.TimeSpan offset) { throw null; }
    }

    public partial class MemoryCacheEntryOptions
    {
        public System.DateTimeOffset? AbsoluteExpiration { get { throw null; } set { } }
        public System.TimeSpan? AbsoluteExpirationRelativeToNow { get { throw null; } set { } }
        public System.Collections.Generic.IList<Primitives.IChangeToken> ExpirationTokens { get { throw null; } }
        public System.Collections.Generic.IList<PostEvictionCallbackRegistration> PostEvictionCallbacks { get { throw null; } }
        public CacheItemPriority Priority { get { throw null; } set { } }
        public long? Size { get { throw null; } set { } }
        public System.TimeSpan? SlidingExpiration { get { throw null; } set { } }
    }

    public partial class MemoryCacheStatistics
    {
        public long CurrentEntryCount { get { throw null; } init { } }
        public long? CurrentEstimatedSize { get { throw null; } init { } }
        public long TotalHits { get { throw null; } init { } }
        public long TotalMisses { get { throw null; } init { } }
    }

    public partial class PostEvictionCallbackRegistration
    {
        public PostEvictionDelegate? EvictionCallback { get { throw null; } set { } }
        public object? State { get { throw null; } set { } }
    }

    public delegate void PostEvictionDelegate(object key, object? value, EvictionReason reason, object? state);
}

namespace Microsoft.Extensions.Internal
{
    public partial interface ISystemClock
    {
        System.DateTimeOffset UtcNow { get; }
    }

    public partial class SystemClock : ISystemClock
    {
        public System.DateTimeOffset UtcNow { get { throw null; } }
    }
}