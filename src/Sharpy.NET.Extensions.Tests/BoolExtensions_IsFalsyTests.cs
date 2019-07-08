using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class BoolExtensions_IsFalsyTests
    {
        [Fact]
        public void when_bool_is_false_isfalsy_method_return_true()
        {
            bool b = false;
            
            Assert.True(b.IsFalsy());
        }

        [Fact]
        public void when_bool_is_true_isfalsy_method_return_false()
        {
            bool b = true;

            Assert.False(b.IsFalsy());
        }
    }
}
