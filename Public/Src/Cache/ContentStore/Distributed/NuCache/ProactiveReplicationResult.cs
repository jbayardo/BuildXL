﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BuildXL.Cache.ContentStore.Interfaces.Results;

namespace BuildXL.Cache.ContentStore.Distributed.NuCache
{
    /// <summary>
    /// Result of proactive replication for customized result logging 
    /// </summary>
    public class ProactiveReplicationResult : ResultBase
    {
        /// <nodoc />
        public int SuccessCount { get; }

        /// <nodoc />
        public int FailCount { get; }

        /// <nodoc />
        public int TotalLocalContent { get; }

        /// <nodoc />
        public ProactiveReplicationResult(int succeeded, int failed, int totalLocalContent)
        {
            SuccessCount = succeeded;
            FailCount = failed;
            TotalLocalContent = totalLocalContent;
        }

        /// <nodoc />
        public ProactiveReplicationResult(ResultBase other, string message = null) : base(other, message)
        {
        }

        /// <inheritdoc />
        protected override string GetSuccessString() => $"{base.GetSuccessString()} (Succeeded={SuccessCount}, Failed={FailCount}, Total={SuccessCount + FailCount}, TotalLocalContent={TotalLocalContent})";
    }
}
