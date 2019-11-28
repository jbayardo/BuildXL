// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.Results;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    // NOTE: these are just temporary, but we would need to take a decision in this regard (i.e. replace?, rename?)
    using LookupResult = PinResult;
    using RetrieveStreamResult = OpenStreamResult;
    using RetrieveFileResult = PlaceFileResult;
    using InsertResult = PutResult;

    public class ExampleImplementationA1 : IContentCacheA1
    {
        public string Name => throw new System.NotImplementedException();

        public bool StartupCompleted => throw new System.NotImplementedException();

        public bool StartupStarted => throw new System.NotImplementedException();

        public bool ShutdownCompleted => throw new System.NotImplementedException();

        public bool ShutdownStarted => throw new System.NotImplementedException();

        public Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkDeleteAsync(Context context, IReadOnlyList<DeleteRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertFileAsync(Context context, IReadOnlyList<InsertFileRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertStreamAsync(Context context, IReadOnlyList<InsertStreamRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<LookupResult>>>> BulkLookupAsync(Context context, IReadOnlyList<LookupRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<RetrieveFileResult>>>> BulkRetrieveFileAsync(Context context, IReadOnlyList<RetrieveFileRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkRetrieveStreamAsync(Context context, IReadOnlyList<RetrieveStreamRequest> requests, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<CreatePinResult> CreatePinAsync(Context context, CreatePinRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteResult> DeleteAsync(Context context, DeleteRequest request, CancellationToken cancellationToken = default)
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

        public Task<InsertResult> InsertFileAsync(Context context, InsertFileRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<InsertResult> InsertStreamAsync(Context context, InsertStreamRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<LookupResult> LookupAsync(Context context, LookupRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReleasePinResult> ReleasePinAsync(Context context, ReleasePinRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<RetrieveFileResult> RetrieveFileAsync(Context context, RetrieveFileRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<RetrieveStreamResult> RetrieveStreamAsync(Context context, RetrieveStreamRequest request, CancellationToken cancellationToken = default)
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
