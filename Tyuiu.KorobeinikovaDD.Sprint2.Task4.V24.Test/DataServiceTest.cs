using Tyuiu.KorobeinikovaDD.Sprint2.Task4.V24.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidCoundition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -24;
            double wait = 0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCoundition2()
        {

            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 0.833;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}