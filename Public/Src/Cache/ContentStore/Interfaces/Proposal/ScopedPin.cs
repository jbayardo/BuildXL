#nullable enable
using System;
using System.Diagnostics.ContractsLight;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    public sealed class ScopedPin : IDisposable
    {
        private readonly Context _context;
        private readonly IContentCache _cache;

        public Pin Pin { get; }

        public ScopedPin(Context context, IContentCache cache, Pin pin)
        {
            _context = context;
            _cache = cache;
            Pin = pin;
        }

        public void Dispose()
        {
            _cache.ReleasePinAsync(_context, new ReleasePinRequest(Pin)).Wait();
        }
    }

    public static partial class PinExtensions
    {
        public static async Task<ScopedPin> CreateScopedPinAsync(this IContentCache cache, Context context, CreatePinRequest? request = null, CancellationToken cancellationToken = default)
        {
            request ??= new CreatePinRequest();
            var result = await cache.CreatePinAsync(context, request, cancellationToken);
            Contract.Assert(result.Succeeded);
            return new ScopedPin(context, cache, result.Pin);
        }
    }
}
