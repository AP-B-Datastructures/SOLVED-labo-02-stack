using System;

namespace Stack.library
{
    public class StackMath
    {
        private char[] _data = new char[10];
        private int _top = 0;

        public bool IsEmpty => this._top == 0;

        public bool IsFull => this._top == this._data.Length;

        public StackMath(int initialSize = 10)
        {
            this._data = new char[initialSize];
        }

        // geeft TRUE terug wanneer de gegeven formule geldig is, anders FALSE.
        // - formula: een string met de formule die gevalideerd moet worden.
        public bool EvaluateFormula(string formula)
        {
            foreach(var c in formula)
            {
                if (c == '(')
                {
                    this.Push(c);
                }
                if (c == ')')
                {
                    try
                    {
                        this.Pop();
                    }
                    catch (System.Exception)
                    {
                        return false;
                    }
                }
            }

            return this.IsEmpty;
        }

        public void Push(char newValue)
        {
            if (this.IsFull)
            {
                this.ResizeArray();
            }

            this._data[this._top] = newValue;
            this._top++;
        }

        public char Pop()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Pop failed because stack is empty");
            }
            this._top--;
            return this._data[this._top];
        }

        private void ResizeArray()
        {
            char[] newDataArray = new char[this._data.Length * 2];

            for (int i = 0; i < this._data.Length; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }
    }
}
