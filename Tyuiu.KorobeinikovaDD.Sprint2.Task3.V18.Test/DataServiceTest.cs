using Tyuiu.KorobeinikovaDD.Sprint2.Task3.V18.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCoundition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 72;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCoundition2()
        {

            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCoundition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCoundition4()
        {
            DataService ds = new DataService();
            double x = -25;
            double wait = -274.96;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}