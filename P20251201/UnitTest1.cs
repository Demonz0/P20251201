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
            

        }
        [Test]
        public void Test2()
        {
            //Assert.Pass();
            StringAssert.Contains("@", "Pelda@valami.hu", message: "Benne van a keresett karakter.");

        }
        [Test]
        public void Test3()
        {
            //Assert.Pass();
            StringAssert.Contains("+36", "+36 30 123 4567", message: "Benne van a keresett karakter.");

        }
        [Test]
        public void Test4()
        {
            //Assert.Pass();
            StringAssert.Contains("+36", "+04 123 4567", message: "Nincs benne a keresett karakter.");

        }
        [Test]
        public void Test5()
        {
            //Assert.Pass();
            int jelszohossz = 0;
            Assert.IsTrue("asd12345".Length > 6, message:"Hosszabb mint a minnimum");

        }
    }
}