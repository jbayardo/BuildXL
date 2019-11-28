// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable
using BuildXL.Cache.ContentStore.Hashing;
using BuildXL.Cache.ContentStore.Interfaces.Sessions;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    public class PinOptions
    {
        /// <summary>
        /// Which pin to put this content under
        /// </summary>
        public Pin Pin { get; }

        /// <summary>
        /// Approximate bound on "probability that the pin finishes successfully, but file is not actually there later
        /// on".
        ///
        /// The higher this number is, the less work the cache needs to do. By default, the cache decides how much risk
        /// is acceptable.
        /// </summary>
        public double? Risk { get; set; } = null;

        public PinOptions(Pin pin)
        {
            Pin = pin;
        }
    }

    public enum WorkHint
    {
        /// <summary>
        /// All necessary work happens within the returned task.
        /// </summary>
        Inlined = 0,

        /// <summary>
        /// Minimal amount of work possible to guarantee the operations' success or failure, and leaves the rest
        /// running in the background.
        /// </summary>
        Minimal = 1,
    }

    public class CommonOptions
    {
        /// <summary>
        /// Each operation triggers many internal book keeping tasks. These tasks are needed to ensure eventual
        /// consistency of the cache. This option allows you to have those tasks happen in the background instead of
        /// inlined in the operation's task.
        /// </summary>
        public WorkHint WorkHint { get; set; } = WorkHint.Inlined;

        /// <summary>
        /// Whether this operation should update the last access time of the content
        /// </summary>
        public bool Touch { get; set; } = true;

        /// <summary>
        /// Whether this operation should pin the content.
        /// </summary>
        /// <remarks>
        /// Default is to not pin.
        /// </remarks>
        public PinOptions? Pin { get; set; } = null;
    }

    public class LookupOptions : CommonOptions
    {
    }

    public class InsertStreamOptions : CommonOptions
    {
        public ContentHash? ExpectedHash { get; set; } = null;
    }

    public class InsertFileOptions : CommonOptions
    {
        /// <summary>
        /// Content ingress method allowed by caller.
        /// </summary>
        public FileRealizationMode RealizationMode { get; set; } = FileRealizationMode.Any;

        public ContentHash? ExpectedHash { get; set;  } = null;
    }

    public class RetrieveStreamOptions : CommonOptions
    {
    }

    public class RetrieveFileOptions : CommonOptions
    {
        public FileAccessMode AccessMode { get; set; } = FileAccessMode.None;

        public FileReplacementMode ReplacementMode { get; set; } = FileReplacementMode.None;

        public FileRealizationMode RealizationMode { get; set; } = FileRealizationMode.Any;
    }
}
