using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class EnumerableExtensions_SizeTests
    {
        [Fact]
        public void when_array_is_empty_size_method_return_zero()
        {
            object[] array = new object[0];

            Assert.Empty(array);
            Assert.Equal(0, array.Size());
        }

        [Fact]
        public void when_array_is_not_empty_size_method_return_number_of_elements()
        {
            object[] array = new object[1];

            Assert.NotEmpty(array);
            Assert.Equal(array.Length, array.Size());
        }

        [Fact]
        public void when_enumerable_is_empty_size_method_return_zero()
        {
            IEnumerable<object> enumerable = new List<object>();

            Assert.Empty(enumerable);
            Assert.Equal(0, enumerable.Size());
        }

        [Fact]
        public void when_enumerable_is_not_empty_size_method_return_number_of_elements()
        {
            IEnumerable<object> enumerable = new List<object> { new object() };

            Assert.NotEmpty(enumerable);
            Assert.Equal(enumerable.Count(), enumerable.Size());
        }
    }
}
