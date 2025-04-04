using System;

namespace Stack.library
{
    public class StackMath
    {
        private char[] data = new char[10];
        private int top = -1;

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();

        public StackMath(int initialSize = 10)
        {
            throw new NotImplementedException();
        }

        // geeft TRUE terug wanneer de gegeven formule geldig is, anders FALSE.
        // - formula: een string met de formule die gevalideerd moet worden.
        public bool EvaluateFormula(string formula)
        {
            throw new NotImplementedException();
        }

        public void Push(char newValue)
        {
            throw new NotImplementedException();
        }

        public char Pop()
        {
            throw new NotImplementedException();
        }

        private void ResizeArray()
        {
            throw new NotImplementedException();
        }
    }
}
