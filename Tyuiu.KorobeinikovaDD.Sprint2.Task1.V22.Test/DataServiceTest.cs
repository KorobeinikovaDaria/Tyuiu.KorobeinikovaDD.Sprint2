
using Tyuiu.KorobeinikovaDD.Sprint2.Task1.V22.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            var a = 324;
            var b = 696;
            var c = 254;
            var d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}