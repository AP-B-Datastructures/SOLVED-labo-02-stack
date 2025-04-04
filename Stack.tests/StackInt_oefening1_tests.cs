using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackInt_oefening1_tests
    {
        private StackInt stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackInt();
        }

        [TestMethod]
        public void Push_AddsElementToStack()
        {
            // Arrange
            int element = 10;

            // Act
            stack.Push(element);

            // Assert
            Assert.AreEqual(element, stack.Pop());
        }

        [TestMethod]
        public void Pop_RemovesAndReturnsTopElement()
        {
            // Arrange
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            int topElement = stack.Pop();

            // Assert
            Assert.AreEqual(3, topElement);
        }
    }
}
