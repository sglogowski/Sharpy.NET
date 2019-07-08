using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class ObjectExtensions_IsNullTests
    {
        [Fact]
        public void when_object_is_null_isnull_method_return_true()
        {
            object o = null;

            Assert.Null(o);
            Assert.True(o.IsNull());
        }

        [Fact]
        public void when_object_is_not_null_isnull_method_return_false()
        {
            object o = new object();

            Assert.NotNull(o);
            Assert.False(o.IsNull());
        }
    }
}
