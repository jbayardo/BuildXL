using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.Extensions;
using BuildXL.Cache.ContentStore.Interfaces.Results;
using BuildXL.Cache.ContentStore.Interfaces.Sessions;
using BuildXL.Cache.ContentStore.Interfaces.Stores;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    using LookupResult = PinResult;
    using RetrieveStreamResult = OpenStreamResult;
    using RetrieveFileResult = PlaceFileResult;
    using InsertResult = PutResult;

    public interface ICacheOperation<OperationT, ResultT>
    {
        public Task<IEnumerable<Task<Indexed<ResultT>>>> BulkExecuteAsync(Context context, IReadOnlyList<OperationT> operation, CancellationToken cancellationToken = default);
    }

    public interface IContentCacheA2
        : IName,
          IStartupShutdown,
          ICacheOperation<LookupRequest, LookupResult>,
          ICacheOperation<InsertFileRequest, InsertResult>,
          ICacheOperation<InsertStreamRequest, InsertResult>,
          ICacheOperation<RetrieveFileRequest, RetrieveFileResult>,
          ICacheOperation<RetrieveStreamRequest, RetrieveStreamResult>,
          ICacheOperation<DeleteRequest, DeleteResult>,
          ICacheOperation<CreatePinRequest, CreatePinResult>,
          ICacheOperation<ReleasePinRequest, ReleasePinResult> {
        Task<GetStatsResult> GetStatsAsync(Context context);
    }
}
