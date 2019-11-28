// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using System.Diagnostics.ContractsLight;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    /// <summary>
    /// A Pin object can only be created by the cache code, and is essentially a lifetime control mechanism via
    /// reference counting.
    ///
    /// The existance of a pin over a piece of content implies that the content can't be evicted from the cache until
    /// all pins over it are released (i.e. until the count is 0).
    /// </summary>
    public class Pin
    {
        internal Pin()
        {

        }
    }

    /// <summary>
    /// Replacement for a session-scoped pin.
    /// </summary>
    public class SessionBasedPin : Pin
    {
        internal string SessionId { get; }

        internal SessionBasedPin(string identifier)
        {
            Contract.RequiresNotNullOrEmpty(identifier);
            SessionId = identifier;
        }
    }
}
