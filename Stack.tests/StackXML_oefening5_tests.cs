using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackXML_oefening5_tests
    {
        private StackXML stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackXML();
        }

        [DataTestMethod]
        [DataRow("<test></test>")]
        [DataRow("<bla></bla>")]
        public void EvaluateXML_SingleEmptyElementIsValid(string formula) { 
            var result = stack.ValidateXML(formula);

            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("<test>qsdf</test>")]
        [DataRow("<bla>qsdf qsdf</bla>")]
        public void EvaluateXML_SingleFilledElementIsValid(string formula)
        {
            var result = stack.ValidateXML(formula);

            Assert.AreEqual(true, result);
        }

        [DataTestMethod]
        [DataRow("<test>")]
        [DataRow("<bla>")]
        public void EvaluateXML_OpenElementIsInvalid(string formula)
        {
            var result = stack.ValidateXML(formula);

            Assert.AreEqual(false, result);
        }

        [DataTestMethod]
        [DataRow("</test>")]
        [DataRow("</bla>")]
        public void EvaluateXML_ClosingUnopenedElementIsInvalid(string formula)
        {
            var result = stack.ValidateXML(formula);

            Assert.AreEqual(false, result);
        }
    }
}
