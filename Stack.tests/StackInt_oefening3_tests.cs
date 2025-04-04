using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackInt_oefening3_tests
    {
        private StackInt stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackInt();
        }

        [TestMethod]
        public void Push_StackIncreasesSize() { 
            // Arrange
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }

            // Assert
            Assert.AreEqual(stack.Pop(), 999);
        }
    }
}
