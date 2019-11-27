#nullable enable
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Interfaces.FileSystem;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;

namespace BuildXL.Cache.ContentStore.Interfaces.Proposal
{
    public class Examples
    {
        public IContentCache Cache { get; } = null;

        public async Task ExampleOneAsync(Context context, AbsolutePath filePath)
        {
            // This would be created at the beginning of the "session", and all further pins would use it
            using var scope = await Cache.CreateScopedPinAsync(context);

            var options = new InsertFileOptions()
            {
                Pin = new PinOptions(scope.Pin)
            };

            var result = await Cache.InsertFileAsync(context, new InsertFileRequest(Hashing.HashType.Vso0, filePath, options));
        }
    }
}
