using System;
using Stack.library;

namespace Stack.tests
{
    [TestClass]
    public class StackInt_oefening2_tests
    {
        private StackInt stack;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            stack = new StackInt();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Act
            stack.Pop();
        }

        [TestMethod]
        public void IsEmpty_FilledStackIsNotEmpty()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.IsEmpty;

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsFull_PartiallyFilledStackIsNotFull()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.IsFull;

            Assert.AreEqual(false, result);
        }

    }
}
