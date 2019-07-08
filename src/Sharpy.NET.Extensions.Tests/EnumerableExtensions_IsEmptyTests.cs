using System.Collections.Generic;
using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class EnumerableExtensions_IsEmptyTests
    {
        [Fact]
        public void when_array_is_empty_isempty_method_return_true()
        {
            object[] array = new object[0];

            Assert.Empty(array);
            Assert.True(array.IsEmpty());
        }

        [Fact]
        public void when_array_is_not_empty_isempty_method_return_false()
        {
            object[] array = new object[1];

            Assert.NotEmpty(array);
            Assert.False(array.IsEmpty());
        }

        [Fact]
        public void when_enumerable_is_empty_isempty_method_return_true()
        {
            IEnumerable<object> enumerable = new List<object>();

            Assert.Empty(enumerable);
            Assert.True(enumerable.IsEmpty());
        }

        [Fact]
        public void when_enumerable_is_not_empty_isempty_method_return_false()
        {
            IEnumerable<object> enumerable = new List<object> { new object() };

            Assert.NotEmpty(enumerable);
            Assert.False(enumerable.IsEmpty());
        }
    }
}
