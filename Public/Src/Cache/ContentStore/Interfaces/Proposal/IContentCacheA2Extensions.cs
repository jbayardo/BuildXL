using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.Results;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    using LookupResult = PinResult;
    using RetrieveStreamResult = OpenStreamResult;
    using RetrieveFileResult = PlaceFileResult;
    using InsertResult = PutResult;

    public static class IContentCacheA2Extensions
    {
        public static async Task<LookupResult> LookupAsync(
            this ICacheOperation<LookupRequest, LookupResult> cache,
            Context context,
            LookupRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<LookupResult>>>> BulkLookupAsync(
            this ICacheOperation<LookupRequest, LookupResult> cache,
            Context context,
            IReadOnlyList<LookupRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<InsertResult> InsertFileAsync(
            this ICacheOperation<InsertFileRequest, InsertResult> cache,
            Context context,
            InsertFileRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertFileAsync(
            this ICacheOperation<InsertFileRequest, InsertResult> cache,
            Context context,
            IReadOnlyList<InsertFileRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<InsertResult> InsertStreamAsync(
            this ICacheOperation<InsertStreamRequest, InsertResult> cache,
            Context context,
            InsertStreamRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertStreamAsync(
            this ICacheOperation<InsertStreamRequest, InsertResult> cache,
            Context context,
            IReadOnlyList<InsertStreamRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<RetrieveFileResult> RetrieveFileAsync(
            this ICacheOperation<RetrieveFileRequest, RetrieveFileResult> cache,
            Context context,
            RetrieveFileRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<RetrieveFileResult>>>> BulkRetrieveFileAsync(
            this ICacheOperation<RetrieveFileRequest, RetrieveFileResult> cache,
            Context context,
            IReadOnlyList<RetrieveFileRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<RetrieveStreamResult> RetrieveStreamAsync(
            this ICacheOperation<RetrieveStreamRequest, RetrieveStreamResult> cache,
            Context context,
            RetrieveStreamRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkRetrieveStreamAsync(
            this ICacheOperation<RetrieveStreamRequest, RetrieveStreamResult> cache,
            Context context,
            IReadOnlyList<RetrieveStreamRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<DeleteResult> DeleteAsync(
            this ICacheOperation<DeleteRequest, DeleteResult> cache,
            Context context,
            DeleteRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static Task<IEnumerable<Task<Indexed<DeleteResult>>>> BulkDeleteAsync(
            this ICacheOperation<DeleteRequest, DeleteResult> cache,
            Context context,
            IReadOnlyList<DeleteRequest> requests,
            CancellationToken cancellationToken = default) => cache.BulkExecuteAsync(context, requests, cancellationToken);

        public static async Task<CreatePinResult> CreatePinAsync(
            this ICacheOperation<CreatePinRequest, CreatePinResult> cache,
            Context context,
            CreatePinRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }

        public static async Task<ReleasePinResult> ReleasePinAsync(
            this ICacheOperation<ReleasePinRequest, ReleasePinResult> cache,
            Context context,
            ReleasePinRequest request,
            CancellationToken cancellationToken = default)
        {
            var enumerable = await cache.BulkExecuteAsync(context, new[] { request }, cancellationToken);
            var task = await enumerable.First();
            return task.Item;
        }
    }
}
