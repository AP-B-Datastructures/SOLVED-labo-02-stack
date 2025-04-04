using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackMath_oefening4_tests
    {

        private StackMath stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackMath();
        }

        [TestMethod]
        public void EvaluateFormula_EmptyStringIsValid()
        {
            var result = stack.EvaluateFormula("");

            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("1+2")]
        [DataRow("1+2+3")]
        [DataRow("12+233+34+45555")]
        public void EvaluateFormula_StringWithoutBracketsIsValid(string formula)
        {
            var result = stack.EvaluateFormula(formula);

            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        public void EvaluateFormula_ValidSinglePairOfBrackets(string formula)
        {
            throw new NotImplementedException();
        }

        [DataTestMethod]
        public void EvaluateFormula_InvalidSinglePairOfBrackets(string formula)
        {
            throw new NotImplementedException();
        }
    }
}
