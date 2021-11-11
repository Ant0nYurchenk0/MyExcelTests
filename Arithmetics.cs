using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExcel;
namespace MyExcelTests
{
    [TestClass]
    public class Arithmetics
    {
        [TestMethod]
        public void TestMethod()
        {
            string expression = "5*5+21/7-4";
            string expected = "24";
            string actual = Calculator.Evaluate(expression);
            Assert.AreEqual(expected, actual);
        }
    }
}
