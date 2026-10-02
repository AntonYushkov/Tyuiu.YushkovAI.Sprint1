using Tyuiu.YushkovAI.Sprint1.Task4.V1.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.111, ds.Calculate(1));
        }
    }
}
