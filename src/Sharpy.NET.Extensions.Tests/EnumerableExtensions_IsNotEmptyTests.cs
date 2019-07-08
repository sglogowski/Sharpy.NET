using System.Collections.Generic;
using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class EnumerableExtensions_IsNotEmptyTests
    {
        [Fact]
        public void when_array_is_empty_isnotempty_method_return_false()
        {
            object[] array = new object[0];

            Assert.Empty(array);
            Assert.False(array.IsNotEmpty());
        }

        [Fact]
        public void when_array_is_not_empty_isnotempty_method_return_true()
        {
            object[] array = new object[1];

            Assert.NotEmpty(array);
            Assert.True(array.IsNotEmpty());
        }

        [Fact]
        public void when_enumerable_is_empty_isnotempty_method_return_false()
        {
            IEnumerable<object> enumerable = new List<object>();

            Assert.Empty(enumerable);
            Assert.False(enumerable.IsNotEmpty());
        }

        [Fact]
        public void when_enumerable_is_not_empty_isnotempty_method_return_true()
        {
            IEnumerable<object> enumerable = new List<object> { new object() };

            Assert.NotEmpty(enumerable);
            Assert.True(enumerable.IsNotEmpty());
        }
    }
}
