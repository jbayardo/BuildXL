// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using System.Diagnostics.ContractsLight;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    public class Pin
    {
        internal string Identifier { get; }

        internal Pin(string identifier)
        {
            Contract.RequiresNotNullOrEmpty(identifier);
            Identifier = identifier;
        }
    }
}
