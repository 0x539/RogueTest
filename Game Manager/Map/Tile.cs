using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Tile
    {
        private bool _isHabitable;
        public bool isHabitable
        {
            get { return this._isHabitable; }
        }

        char _character;
        ConsoleColor _colour;

        public Tile(char character)
        {
            this._isHabitable = true;

            this._character = character;

            switch (character)
            {
                case '#':
                    this._isHabitable = false;
                    this._colour = ConsoleColor.Gray;
                    break;
                case '^':
                    this._isHabitable = false;
                    this._colour = ConsoleColor.Green;
                    break;
                case 'X':
                    this._colour = ConsoleColor.Red;
                    break;
                default:
                    this._colour = ConsoleColor.Gray;
                    break;
            }
        }

        public void Draw()
        {
            
            Console.ForegroundColor = this._colour;

            Console.Write(this._character);

            //Default Colour
            if (Console.ForegroundColor != ConsoleColor.Gray)
                Console.ForegroundColor = ConsoleColor.Gray;
        }
    }


}
