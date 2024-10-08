using Tyuiu.KorobeinikovaDD.Sprint2.Task5.V8.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int n = 1;
            int m = 2;
            Assert.AreEqual("31 январ€", ds.FindDateOfPreviousDay(m, n));
        }
    }
}