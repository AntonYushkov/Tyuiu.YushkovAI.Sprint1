using Tyuiu.YushkovAI.Sprint1.Task3.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(74.035, ds.TravelCost(67, 8.5, 6.5));
        }
    }
}
