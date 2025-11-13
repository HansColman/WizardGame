using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWizardCalculator
{
    [TestClass]
    public class UnitTestWizardCalculator
    {
        [TestMethod]
        public void TestPositiveCalculate()
        {
            ScoreBoard.Calculator calc;
            calc = new ScoreBoard.Calculator();
            int result = calc.calculate(0, 0);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestNegativeCalculate()
        {
            ScoreBoard.Calculator calc;
            calc = new ScoreBoard.Calculator();
            int result = calc.calculate(1, 0);
            Assert.AreEqual(-10, result);
        }
        [TestMethod]
        public void TestNegativeCalculateTwo()
        {
            ScoreBoard.Calculator calc;
            calc = new ScoreBoard.Calculator();
            int result = calc.calculate(0, 1);
            Assert.AreEqual(-10, result);
        }
        [TestMethod]
        public void TestMultipleScenarios()
        {
            ScoreBoard.Calculator Calc = new ScoreBoard.Calculator();
            int result = Calc.calculate(1, 0);
            Assert.AreEqual(-10, result);
            result = Calc.calculate(2, 0);
            Assert.AreEqual(-20, result);
        }
    }
}
