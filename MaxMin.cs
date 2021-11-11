using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExcel;

namespace MyExcelTests
{
    [TestClass]
    public class MaxMin

    {
        [TestMethod]
        public void TestMethod()
        {
            string expression = "max(1, 3) + min(4, 5)";
            string expected = "7";
            string actual = Calculator.Evaluate(expression);
            Assert.AreEqual(actual, expected);
        }
    }
}
