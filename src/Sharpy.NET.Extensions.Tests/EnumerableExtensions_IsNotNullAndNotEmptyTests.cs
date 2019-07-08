using System.Collections.Generic;
using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class EnumerableExtensions_IsNotNullAndNotEmptyTests
    {
        [Fact]
        public void when_array_is_null_isnotnullandnotempty_method_return_false()
        {
            object[] array = null;

            Assert.Null(array);
            Assert.False(array.IsNotNullAndNotEmpty());
        }

        [Fact]
        public void when_array_is_empty_isnotnullandnotempty_method_return_false()
        {
            object[] array = new object[0];

            Assert.Empty(array);
            Assert.False(array.IsNotNullAndNotEmpty());
        }

        [Fact]
        public void when_array_is_not_empty_isnotnullandnotempty_method_return_true()
        {
            object[] array = new object[1];

            Assert.NotEmpty(array);
            Assert.True(array.IsNotNullAndNotEmpty());
        }

        [Fact]
        public void when_enumerable_is_null_isnotnullandnotempty_method_return_false()
        {
            IEnumerable<object> enumerable = null;

            Assert.Null(enumerable);
            Assert.False(enumerable.IsNotNullAndNotEmpty());
        }

        [Fact]
        public void when_enumerable_is_empty_isnotnullandnotempty_method_return_false()
        {
            IEnumerable<object> enumerable = new List<object>();

            Assert.Empty(enumerable);
            Assert.False(enumerable.IsNotNullAndNotEmpty());
        }

        [Fact]
        public void when_enumerable_is_not_empty_isnotnullandnotempty_method_return_true()
        {
            IEnumerable<object> enumerable = new List<object> { new object() };

            Assert.NotEmpty(enumerable);
            Assert.True(enumerable.IsNotNullAndNotEmpty());
        }
    }
}
