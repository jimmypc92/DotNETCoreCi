namespace Tests
{
    using Xunit;

    public class Util
    {
        [Fact]
        public void Add()
        {
            Assert.True(DotNETCoreCi.Util.Add(1, 5) == 6);
        }
    }
}
