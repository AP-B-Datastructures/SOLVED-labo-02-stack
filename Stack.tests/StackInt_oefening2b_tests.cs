using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackInt_oefening2b_tests
    {
        private StackInt stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackInt();
        }


        [DataTestMethod]
        [DataRow(3)]
        [DataRow(0)]
        [DataRow(5)]
        public void IsEmpty_EmptyStackIsEmpty(int numberOfPushAndPops)
        {
            // Arrange

            // Act
            for (var i = 0; i < numberOfPushAndPops; ++i)
            {
                stack.Push(i);
            }
            for (var i = 0; i < numberOfPushAndPops; ++i)
            {
                stack.Pop();
            }

            // Assert
            Assert.AreEqual(true, stack.IsEmpty);
        }

        [TestMethod]
        public void IsFull_FullStackIsFull()
        {
            // Arrange

            // Act
            for (var i = 0; i < 10; ++i)
            {
                stack.Push(i);
            }

            // Assert
            Assert.AreEqual(true, stack.IsFull);
        }
    }
}
