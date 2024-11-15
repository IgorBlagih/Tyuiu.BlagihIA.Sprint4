using Tyuiu.BlagihIA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            string[] array = { "Áאמבאב", "Åכü" };
            string[] res = ds.Calculate(array);

            string[] array2 = { "Áאמבאב" };
            
            CollectionAssert.AreEqual(array2, res);
        }
    }
}