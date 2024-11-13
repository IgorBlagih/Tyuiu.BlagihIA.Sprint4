using Tyuiu.BlagihIA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 4 };
            int wait = 6;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}