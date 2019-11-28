// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using System.IO;
using BuildXL.Cache.ContentStore.Hashing;
using BuildXL.Cache.ContentStore.Interfaces.FileSystem;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    // PROS:
    //  - We can at any time add new arguments to the functions
    //  - Bulk semantics are clear
    // CONS:
    //  - Verbose, although we can simplify that by providing convenience functions

    public class LookupRequest
    {
        public ContentHash ContentHash { get; }

        public LookupOptions? Options { get; set; } = null;

        public LookupRequest(ContentHash contentHash, LookupOptions? options = null)
        {
            ContentHash = contentHash;
            Options = options;
        }
    }

    public class RetrieveStreamRequest
    {
        public ContentHash ContentHash { get; }

        public RetrieveStreamOptions? Options { get; set; } = null;

        public RetrieveStreamRequest(ContentHash contentHash, RetrieveStreamOptions? options = null)
        {
            ContentHash = contentHash;
            Options = options;
        }
    }


    public class RetrieveFileRequest
    {
        public ContentHash ContentHash { get; }

        public AbsolutePath Path { get; }

        public RetrieveFileOptions? Options { get; set; } = null;

        public RetrieveFileRequest(ContentHash contentHash, AbsolutePath path, RetrieveFileOptions? options = null)
        {
            ContentHash = contentHash;
            Path = path;
            Options = options;
        }
    }

    public class InsertFileRequest
    {
        public HashType HashType { get; }

        public AbsolutePath Path { get; }

        public ContentHash? ExpectedHash { get; set; } = null;

        public InsertFileOptions? Options { get; set; } = null;

        public InsertFileRequest(HashType hashType, AbsolutePath path, ContentHash? expectedHash = null, InsertFileOptions? options = null)
        {
            HashType = hashType;
            Path = path;
            ExpectedHash = expectedHash;
            Options = options;
        }
    }

    public class InsertStreamRequest
    {
        public HashType HashType { get; }

        public Stream Stream { get; }

        public ContentHash? ExpectedHash { get; set; } = null;

        public InsertStreamOptions? Options { get; set; } = null;

        public InsertStreamRequest(HashType hashType, Stream stream, ContentHash? expectedHash = null, InsertStreamOptions? options = null)
        {
            HashType = hashType;
            Stream = stream;
            ExpectedHash = expectedHash;
            Options = options;
        }
    }

    public class DeleteRequest
    {
        public ContentHash ContentHash { get; }

        public DeleteRequest(ContentHash contentHash)
        {
            ContentHash = contentHash;
        }
    }

    public class CreatePinRequest
    {
        // Nothing in here for now, but we may want to add in the future. For example: "pin should last at least X
        // amount of time"
    }

    public class ReleasePinRequest
    {
        public Pin Pin { get; }

        public ReleasePinRequest(Pin pin)
        {
            Pin = pin;
        }
    }
}
