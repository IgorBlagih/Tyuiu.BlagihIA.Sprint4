using Tyuiu.BlagihIA.Sprint4.Task7.V20.Lib;
namespace Tyuiu.BlagihIA.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int r = 5;
            int c = 3;
            int[,] mtrx = new int[r, c];
            string str =  "164111111111111" ;
            int res = ds.Calculate(r, c, str);
            int wait = 24;

            Assert.AreEqual(wait, res);
        }
    }
} 