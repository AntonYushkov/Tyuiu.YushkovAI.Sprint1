using Tyuiu.YushkovAI.Sprint1.Task6.V7.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Прив ми", ds.DeleteLastLetter("Привет мир"));
        }
    }
}
