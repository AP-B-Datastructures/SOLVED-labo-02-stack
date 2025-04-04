using System;

namespace Stack.library
{
    public class StackXML
    {
        private string[] _data = new string[10];
        private int top = -1;

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();

        public StackXML(int initialSize = 10)
        {
            throw new NotImplementedException();
        }

        // geeft TRUE terug wanneer de gegeven XML string geldig is, anders FALSE.
        // - xml: een XML string die gecontroleerd moet worden.
        public bool ValidateXML(string xml)
        {
            throw new NotImplementedException();
        }

        public void Push(string newValue)
        {
            throw new NotImplementedException();
        }

        public string Pop()
        {
            throw new NotImplementedException();
        }


        private void ResizeArray()
        {
            throw new NotImplementedException();
        }
    }
}
