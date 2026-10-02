using Tyuiu.YushkovAI.Sprint1.Task2.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(24, ds.CalculateParallelepipedVolume(2, 3, 4));
        }
    }
}
