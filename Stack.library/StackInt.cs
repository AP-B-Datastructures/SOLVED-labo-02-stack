using System;

namespace Stack.library
{
    public class StackInt
    {
        #region OEFENING 1
        int[] _data = new int[5];
        int _top = 0;

        // voegt een getal toe aan de stack tot als deze vol is.
        //negeer de waarde als de stack vol is.
        public void Push(int newValue)
        {
            if (this.IsFull)
            {
                this.ResizeArray();
            }

            this._data[this._top] = newValue;
            this._top++;
        }

        // haalt het laatste getal van de stack en geeft deze waarde terug.
        //geef int.MinValue terug als de stack leeg is.
        public int Pop()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Pop failed: stack is empty");
            }
            this._top--;
            return this._data[this._top];
        }

        #endregion

        #region OEFENING 2
        // vul de properties IsEmpty en IsFull in.
        // roep de properties IsEmpty en IsFull aan waar nodig in de functies Push() en Pop(), zodat je een InvalidOperationException toont wanneer de array vol of leeg is.

        // geeft true terug als de stack leeg is, anders false.
        public bool IsEmpty => this._top == 0;

        // geeft true terug als de stack vol is, anders false.
        public bool IsFull => this._top == this._data.Length;

        #endregion

        #region OEFENING 3
        // Vul de functie ResizeArray() in.
        // roep de functie ResizeArray aan vanuit Push, maar enkel wanneer de array vol is. Je moet geen Exception meer tonen als de array vol is.

        // constructor die een initiele grootte mee krijgt.
        // - initialSize: de startgrootte van de array voor de stack.
        public StackInt(int initialSize = 10)
        {
            this._data = new int[initialSize];
        }

        // maakt de array dubbel zo groot.
        private void ResizeArray()
        {
            int[] newDataArray = new int[this._data.Length * 2];

            // Array.Copy(this._data, newDataArray, this._data.Length);
            // of met for-loop:
            for (var i = 0; i < this._data.Length; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }

        #endregion
    }
}
