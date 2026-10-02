using Tyuiu.YushkovAI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(1, ds.Calculate(1));
            Assert.AreEqual(7, ds.Calculate(7));
            Assert.AreEqual(1, ds.Calculate(8));
            Assert.AreEqual(3, ds.Calculate(17));
            Assert.AreEqual(7, ds.Calculate(365));
        }
    }
}
