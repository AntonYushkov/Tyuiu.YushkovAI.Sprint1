using Tyuiu.YushkovAI.Sprint1.Task0.V4.Lib;
namespace Tyuiu.YushkovAI.Sprint1.Task0.V4.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6, ds.Calculate());
        }
    }
}
