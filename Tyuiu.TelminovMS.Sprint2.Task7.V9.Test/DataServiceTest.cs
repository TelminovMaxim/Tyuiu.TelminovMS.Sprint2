using System.Security.Cryptography.X509Certificates;
using Tyuiu.TelminovMS.Sprint2.Task7.V9.Lib;

namespace Tyuiu.TelminovMS.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            
            double x = 1;
            double y = 0.25;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
