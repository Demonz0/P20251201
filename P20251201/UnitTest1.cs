namespace P20251201
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           
            StringAssert.Contains("1", "Pelda@valami.hu");
        }
    }
}