using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExcel;

namespace MyExcelTests
{
    [TestClass]
    public class Logic
    {
        [TestMethod]
        public void TestMethod()
        {
            string expression = "(((not(35)+not(0))>3)=0)<1";
            string expected = "0";
            string actual = Calculator.Evaluate(expression);
            Assert.AreEqual(actual, expected);
        }
    }
    
}
