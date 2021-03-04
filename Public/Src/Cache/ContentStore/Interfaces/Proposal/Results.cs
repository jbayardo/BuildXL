#nullable enable
using BuildXL.Cache.ContentStore.Interfaces.Results;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    public class CreatePinResult : BoolResult
    {
        public Pin Pin { get; }
    }

    public class ReleasePinResult : BoolResult
    {

    }
}
