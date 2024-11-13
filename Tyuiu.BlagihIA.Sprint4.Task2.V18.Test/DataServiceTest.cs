using Tyuiu.BlagihIA.Sprint4.Task2.V18.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 4 };
            int wait = 8;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}