using Xunit;

namespace SharpyNet.Extensions.Tests
{
    public class BoolExtensions_IsTruthyTests
    {
        [Fact]
        public void when_bool_is_false_istruthy_method_return_false()
        {
            bool b = false;

            Assert.False(b.IsTruthy());
        }

        [Fact]
        public void when_bool_is_true_istruthy_method_return_true()
        {
            bool b = true;

            Assert.True(b.IsTruthy());
        }
    }
}
