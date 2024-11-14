using Tyuiu.BlagihIA.Sprint4.Task3.V5.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { 1, 2, 4, 2, 1 },
                                           { 9, 9, 9, 9, 9 },
                                           { 9, 9, 9, 9, 9 },
                                           { 9, 9, 9, 9, 9 },
                                           { 9, 9, 9, 9, 9 }
                                         };


            int wait = 37;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
    
}