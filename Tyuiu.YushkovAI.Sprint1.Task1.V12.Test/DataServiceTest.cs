using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint1.Task1.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint1.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(2, ds.Calculate(6, 6));
        }
    }
}
