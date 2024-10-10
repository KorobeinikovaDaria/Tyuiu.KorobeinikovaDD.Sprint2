using Tyuiu.KorobeinikovaDD.Sprint2.Task6.V9.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int n = 1;
            int m = 12;
            Assert.AreEqual("02.12", ds.FindDateOfNextDay(m, n));
        }
    }
}