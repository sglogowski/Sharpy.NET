using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class TaskEnumerableExtensions_ToArrayAsyncTests
    {
        [Fact]
        public async Task when_convert_taskenumerable_to_taskarray_elements_stay_same()
        {
            object expectedObject = new object();

            IEnumerable<object> enumerable = new List<object> { expectedObject };
            Task<IEnumerable<object>> enumerableInTask = Task.FromResult(enumerable);
            Task<object[]> arrayInTask = enumerableInTask.ToArrayAsync();
            object[] array = await arrayInTask;

            Assert.NotEmpty(enumerable);
            Assert.NotEmpty(array);
            Assert.Same(enumerable.First(), array[0]);
        }
    }
}
