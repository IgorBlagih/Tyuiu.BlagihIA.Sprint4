using Tyuiu.BlagihIA.Sprint4.Task5.V21.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { -2, 2, 4, 2, 1 },
                                           { -9, -9, -9,-9, 9 },
                                           { -9, 9, -7, 9, 9 },
                                           { 9, -2, 9, 0, 9 },
                                           { 9, 9, 0, 9, 9 }
                                         };


            int[,] wait = new int[5, 5] { { -2, 1, 1, 1, 1 },
                                           { -9, -9, -9,-9, 1 },
                                           { -9, 1, -7, 1, 1 },
                                           { 1, -2, 1, 0, 1 },
                                           { 1, 1, 0, 1, 1 }
                                         };
            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}