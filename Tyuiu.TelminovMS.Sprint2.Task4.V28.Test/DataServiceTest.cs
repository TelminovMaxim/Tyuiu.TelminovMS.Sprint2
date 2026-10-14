using Tyuiu.TelminovMS.Sprint2.Task4.V28.Lib;

namespace Tyuiu.TelminovMS.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionTrue()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 13.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditionFalse()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 1.222;
            Assert.AreEqual(wait, res);
        }
    }
}
