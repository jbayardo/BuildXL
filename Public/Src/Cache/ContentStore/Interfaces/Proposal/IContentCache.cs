// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.Results;
using BuildXL.Cache.ContentStore.Interfaces.Sessions;
using BuildXL.Cache.ContentStore.Interfaces.Stores;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    // NOTE: these are just temporary, but we would need to take a decision in this regard (i.e. replace?, rename?)
    using LookupResult = PinResult;
    using RetrieveStreamResult = OpenStreamResult;
    using RetrieveFileResult = PlaceFileResult;
    using InsertResult = PutResult;

    public interface IContentCache : IName, IStartupShutdown
    {
        #region Lookup
        Task<LookupResult> LookupAsync(
            Context context,
            LookupRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<LookupResult>>>> BulkLookupAsync(
            Context context,
            IReadOnlyList<LookupRequest> requests,
            CancellationToken cancellationToken = default);
        #endregion


        #region Insert
        Task<InsertResult> InsertFileAsync(
            Context context,
            InsertFileRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertFileAsync(
            Context context,
            IReadOnlyList<InsertFileRequest> requests,
            CancellationToken cancellationToken = default);

        Task<InsertResult> InsertStreamAsync(
            Context context,
            InsertStreamRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<InsertResult>>>> BulkInsertStreamAsync(
            Context context,
            IReadOnlyList<InsertStreamRequest> requests,
            CancellationToken cancellationToken = default);
        #endregion


        #region Retrieve
        Task<RetrieveFileResult> RetrieveFileAsync(
            Context context,
            RetrieveFileRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<RetrieveFileResult>>>> BulkRetrieveFileAsync(
            Context context,
            IReadOnlyList<RetrieveFileRequest> requests,
            CancellationToken cancellationToken = default);

        Task<RetrieveStreamResult> RetrieveStreamAsync(
            Context context,
            RetrieveStreamRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkRetrieveStreamAsync(
            Context context,
            IReadOnlyList<RetrieveStreamRequest> requests,
            CancellationToken cancellationToken = default);
        #endregion

        #region Delete
        Task<DeleteResult> DeleteAsync(
            Context context,
            DeleteRequest request,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<Task<Indexed<RetrieveStreamResult>>>> BulkDeleteAsync(
            Context context,
            IReadOnlyList<DeleteRequest> requests,
            CancellationToken cancellationToken = default);
        #endregion

        #region Pinning
        Task<CreatePinResult> CreatePinAsync(
            Context context,
            CreatePinRequest request,
            CancellationToken cancellationToken = default);

        Task<ReleasePinResult> ReleasePinAsync(
            Context context,
            ReleasePinRequest request,
            CancellationToken cancellationToken = default);
        #endregion

        #region Other
        Task<GetStatsResult> GetStatsAsync(Context context);
        #endregion
    }
}
