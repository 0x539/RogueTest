using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Messenger
    {
        int _screenPosX;
        int _screenPosY;

        int _maxX;
        int _maxStringLength;

        int _maxY;
        int _maxMessages;

        List<string> _messages;

        public Messenger()
        {
            this._screenPosY = 18;
            this._screenPosX = 50;
            this._messages = new List<string>();

            this._maxX = 79;
            this._maxStringLength = this._maxX - this._screenPosX;

            this._maxY = 24;
            this._maxMessages = this._maxY - this._screenPosY;
        }

        public void AddMessage(string message)
        {
            if (this._messages.Count == this._maxMessages + 1)
                this._messages.Remove(this._messages[0]);

            this._messages.Add(message);
        }

        public void Draw()
        {
            this._messages.Reverse();

            int currentY = this._screenPosY;
            foreach (string s in this._messages)
            {
                Console.SetCursorPosition(this._screenPosX, currentY++);

                Console.Write(this.PadString(s));
            }
            this._messages.Reverse();
        }

        private string PadString(string text)
        {
            if (text.Length > this._maxStringLength)
            {
                //Trim it.
                return text.Substring(0, this._maxStringLength);
            }
            else if (text.Length < this._maxStringLength)
            {
                //Pad it.
                return text.PadRight(this._maxStringLength, ' ');
            }
            else
            {
                //return it.
                return text;
            }
        }
    }
}
