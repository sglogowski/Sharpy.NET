using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class ObjectExtensions_IsNotNullTests
    {
        [Fact]
        public void when_object_is_null_isnotnull_method_return_false()
        {
            object o = null;

            Assert.Null(o);
            Assert.False(o.IsNotNull());
        }

        [Fact]
        public void when_object_is_not_null_isnotnull_method_return_true()
        {
            object o = new object();

            Assert.NotNull(o);
            Assert.True(o.IsNotNull());
        }
    }
}
