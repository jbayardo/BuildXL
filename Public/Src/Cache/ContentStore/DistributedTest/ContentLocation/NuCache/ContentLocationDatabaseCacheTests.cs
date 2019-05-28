using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Distributed.NuCache;
using BuildXL.Cache.ContentStore.Hashing;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;
using BuildXL.Cache.ContentStore.InterfacesTest;
using BuildXL.Cache.ContentStore.InterfacesTest.Results;
using BuildXL.Cache.ContentStore.InterfacesTest.Time;
using BuildXL.Cache.ContentStore.Tracing.Internal;
using ContentStoreTest.Test;
using Xunit;
using Xunit.Abstractions;

namespace BuildXL.Cache.ContentStore.Distributed.Test.ContentLocation.NuCache
{
    class ContentLocationDatabaseCacheTests : TestWithOutput
    {
        protected readonly MemoryClock _clock = new MemoryClock();

        protected ContentLocationDatabaseConfiguration DefaultConfiguration { get; } = new MemoryContentLocationDatabaseConfiguration();

        protected readonly ContentLocationDatabase _database;

        public ContentLocationDatabaseCacheTests(ITestOutputHelper output)
            : base(output)
        {
            _database = ContentLocationDatabase.Create(_clock, DefaultConfiguration, () => new MachineId[] { });
        }

        [Fact]
        async Task AddToCacheDoesNotAffectStore()
        {
            var tracingContext = new Context(TestGlobal.Logger);
            var operationContext = new OperationContext(tracingContext);

            await _database.StartupAsync(operationContext).ShouldBeSuccess();

            var machine = new MachineId(1);
            var hash = new ShortHash(ContentHash.Random());
            _database.LocationAdded(operationContext, hash, machine, 200);
            
            await _database.ShutdownAsync(operationContext).ShouldBeSuccess();
        }

        [Fact]
        void GetFromCacheDoesNotAffectStore()
        {

        }

        [Fact]
        void DeleteFromCacheDoesNotAffectStore()
        {

        }

        [Fact]
        void FlushReifiesChangesIntoStore()
        {

        }

        [Fact]
        void FlushDoesNotAllowConcurrentOperations()
        {

        }

        [Fact]
        void FlushHappensAsScheduled()
        {

        }

        [Fact]
        void FlushHappensAfterKOperations()
        {

        }

        [Fact]
        void CacheMissFetchesFromStore()
        {

        }
    }
}
