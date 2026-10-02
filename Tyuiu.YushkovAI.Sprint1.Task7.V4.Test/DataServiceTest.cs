using Tyuiu.YushkovAI.Sprint1.Task7.V4.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(-0.511, ds.Calculate(1, 2), 0.0001);
        }
    }
}
