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
        public void Pop_LastInFirstOut()
        {
            throw new NotImplementedException();
        }

        [DataTestMethod]
        public void Pop_PopAllValuesRevertsInput()
        {
            throw new NotImplementedException();
        }
    }
}
