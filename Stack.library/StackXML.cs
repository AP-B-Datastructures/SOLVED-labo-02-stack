using System;

namespace Stack.library
{
    public class StackXML
    {
        private string[] _data = new string[10];
        private int _top = 0;

        public bool IsEmpty => this._top == 0;

        public bool IsFull => this._top == this._data.Length;

        public StackXML(int initialSize = 10)
        {
            this._data = new string[initialSize];
        }

        // geeft TRUE terug wanneer de gegeven XML string geldig is, anders FALSE.
        // - xml: een XML string die gecontroleerd moet worden.
        public bool ValidateXML(string xml)
        {
            if (xml[0] != '<')
            {
                return false;
            }

            for (var i = 0; i < xml.Length; ++i)
            {
                var c = xml[i];

                if (c == '<' && xml[i + 1] == '/')
                {
                    string tagname = "";

                    for (var j = i+2; j < xml.Length; ++j)
                    {
                        var t = xml[j];
                        if (t == ' ' || t == '>')
                        {
                            i = j;
                            break;
                        }
                        tagname += t;
                    }

                    try
                    {
                        string openTag = this.Pop();
                        if (openTag != tagname)
                        {
                            return false;
                        }
                    }
                    catch (System.Exception)
                    {
                        return false;
                    }
                }
                else if (c == '<')
                {
                    string tagname = "";

                    for (var j = i+1; j < xml.Length; ++j)
                    {
                        var t = xml[j];
                        if (t == ' ' || t == '>')
                        {
                            i = j;
                            break;
                        }
                        tagname += t;
                    }
                    this.Push(tagname);
                }
            }

            return this.IsEmpty;
        }

        public void Push(string newValue)
        {
            if (this.IsFull)
            {
                this.ResizeArray();
            }

            this._data[this._top] = newValue;
            this._top++;
        }

        public string Pop()
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
            string[] newDataArray = new string[this._data.Length * 2];

            for (int i = 0; i < this._data.Length; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }
    }
}
