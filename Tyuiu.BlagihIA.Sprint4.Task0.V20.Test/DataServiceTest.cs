using Tyuiu.BlagihIA.Sprint4.Task0.V20.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 4 };
            int wait = 2;
            int res = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}