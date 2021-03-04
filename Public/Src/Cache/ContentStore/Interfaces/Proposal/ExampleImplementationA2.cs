using System.Collections.Generic;
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

    public class ExampleImplementationA2 : IContentCacheA2
    {
        public string Name => throw new System.NotImplementedException();

        public bool StartupCompleted => throw new System.NotImplementedException();

        public bool StartupStarted => throw new System.NotImplementedException();

        public bool ShutdownCompleted => throw new System.NotImplementedException();

        public bool ShutdownStarted => throw new System.NotImplementedException();

        public Task<IEnumerable<Task<Indexed<LookupResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<LookupRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<InsertFileRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<InsertStreamRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<RetrieveFileResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<RetrieveFileRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<RetrieveStreamRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<DeleteResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<DeleteRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<CreatePinResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<CreatePinRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<ReleasePinResult>>>> BulkExecuteAsync(Context context, IReadOnlyList<ReleasePinRequest> operation, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<GetStatsResult> GetStatsAsync(Context context)
        {
            throw new System.NotImplementedException();
        }

        public Task<BoolResult> ShutdownAsync(Context context)
        {
            throw new System.NotImplementedException();
        }

        public Task<BoolResult> StartupAsync(Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
