using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackInt_oefening3b_tests
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
        [DataRow(17)]
        public void Pop_LastInFirstOut(int topNumber)
        {
            // Arrange

            // Act
            for (var i = 1; i <= topNumber; ++i)
            {
                stack.Push(i);
            }

            // Assert
            Assert.AreEqual(topNumber, stack.Pop());
        }

        [DataTestMethod]
        public void Pop_PopAllValuesRevertsInput()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] output = new int[input.Length];
            int[] expected = { 5, 4, 3, 2, 1 };

            // Act
            for (var i = 0; i < input.Length; ++i)
            {
                stack.Push(input[i]);
            }
            for (var i = 0; i < input.Length; ++i)
            {
                output[i] = stack.Pop();
            }

            // Assert
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
