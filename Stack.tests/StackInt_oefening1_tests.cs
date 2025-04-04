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

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(7)]
        [DataRow(4291)]
        public void Push_AddsElementToStack(int element)
        {
            // Arrange

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
