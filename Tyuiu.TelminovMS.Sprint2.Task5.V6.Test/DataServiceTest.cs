using Tyuiu.TelminovMS.Sprint2.Task5.V6.Lib;

namespace Tyuiu.TelminovMS.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestValid()
        {
            DataService ds = new DataService();
            int x = 1, y = 14;
            string res = ds.FindCardNameAndValue(x, y);
            Assert.AreEqual(res, "туз пик");
        }
    }
}
