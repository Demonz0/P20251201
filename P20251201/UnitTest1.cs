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
            //Assert.Pass();
            StringAssert.Contains("1", "Pelda@valami.hu", message:"Nincs benne a keresett karakter.");
            StringAssert.Contains("@", "Pelda@valami.hu", message:"Benne van a keresett karakter.");

        }
    }
}