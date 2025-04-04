using System;

namespace Stack.library
{
    public class StackInt
    {
        #region OEFENING 1

        // voegt een getal toe aan de stack tot als deze vol is.
        //negeer de waarde als de stack vol is.
        public void Push(int newValue)
        {
            throw new NotImplementedException();
        }

        // haalt het laatste getal van de stack en geeft deze waarde terug.
        //geef int.MinValue terug als de stack leeg is.
        public int Pop()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OEFENING 2
        // vul de properties IsEmpty en IsFull in.
        // roep de properties IsEmpty en IsFull aan waar nodig in de functies Push() en Pop(), zodat je een InvalidOperationException toont wanneer de array vol of leeg is.

        // geeft true terug als de stack leeg is, anders false.
        public bool IsEmpty => throw new NotImplementedException();

        // geeft true terug als de stack vol is, anders false.
        public bool IsFull => throw new NotImplementedException();

        #endregion

        #region OEFENING 3
        // Vul de functie ResizeArray() in.
        // roep de functie ResizeArray aan vanuit Push, maar enkel wanneer de array vol is. Je moet geen Exception meer tonen als de array vol is.


        // constructor die een initiele grootte mee krijgt.
        // - initialSize: de startgrootte van de array voor de stack.
        public StackInt(int initialSize = 10)
        {
        }

        // maakt de array dubbel zo groot.
        private void ResizeArray()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
