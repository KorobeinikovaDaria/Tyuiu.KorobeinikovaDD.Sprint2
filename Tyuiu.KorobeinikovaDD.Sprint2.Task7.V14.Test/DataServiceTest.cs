using Tyuiu.KorobeinikovaDD.Sprint2.Task7.V14.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotinShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.4;
            double y = -0.4;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}