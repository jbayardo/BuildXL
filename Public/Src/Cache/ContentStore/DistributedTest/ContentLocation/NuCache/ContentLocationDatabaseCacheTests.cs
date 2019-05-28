using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BuildXL.Cache.ContentStore.Distributed.NuCache;
using BuildXL.Cache.ContentStore.Hashing;
using BuildXL.Cache.ContentStore.Interfaces.Tracing;
using BuildXL.Cache.ContentStore.InterfacesTest;
using BuildXL.Cache.ContentStore.InterfacesTest.Results;
using BuildXL.Cache.ContentStore.InterfacesTest.Time;
using BuildXL.Cache.ContentStore.Tracing.Internal;
using ContentStoreTest.Test;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace ContentStoreTest.Distributed.ContentLocation.NuCache
{
    public class ContentLocationDatabaseCacheTests : TestWithOutput
    {
        protected readonly MemoryClock _clock = new MemoryClock();

        protected ContentLocationDatabaseConfiguration DefaultConfiguration { get; } = new MemoryContentLocationDatabaseConfiguration
        {
            CacheEnabled = true,
            // These are just to ensure no flushing happens unless explicitly directed
            CacheFlushingInterval = Timeout.InfiniteTimeSpan,
            CacheMaximumUpdatesPerFlush = 10000
        };

        protected readonly ContentLocationDatabase _database;

        public ContentLocationDatabaseCacheTests(ITestOutputHelper output)
            : base(output)
        {
            _database = ContentLocationDatabase.Create(_clock, DefaultConfiguration, () => new MachineId[] { });
        }

        [Fact]
        public async Task ReadMyWrites()
        {
            var tracingContext = new Context(TestGlobal.Logger);
            var operationContext = new OperationContext(tracingContext);

            await _database.StartupAsync(operationContext).ShouldBeSuccess();

            var machine = new MachineId(1);
            var hash = new ShortHash(ContentHash.Random());

            _database.LocationAdded(operationContext, hash, machine, 200);

            _database.TryGetEntry(operationContext, hash, out var entry).Should().BeTrue();
            entry.ContentSize.Should().Be(200);
            entry.Locations.Count.Should().Be(1);
            entry.Locations[machine].Should().Be(true);
            
            await _database.ShutdownAsync(operationContext).ShouldBeSuccess();
        }

        [Fact]
        public void GetFromCacheDoesNotAffectStore()
        {
        }

        [Fact]
        public void DeleteFromCacheDoesNotAffectStore()
        {

        }

        [Fact]
        public void FlushReifiesChangesIntoStore()
        {

        }

        [Fact]
        public void FlushDoesNotAllowConcurrentOperations()
        {

        }

        [Fact]
        public void FlushHappensAsScheduled()
        {

        }

        [Fact]
        public void FlushHappensAfterKOperations()
        {

        }

        [Fact]
        public void CacheMissFetchesFromStore()
        {

        }
    }
}
