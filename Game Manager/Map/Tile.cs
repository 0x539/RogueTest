using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Tile
    {
        bool isHabitable;

        char _character;
        ConsoleColor _colour;
        ConsoleColor _background;

        public Tile(char character)
        {
            this._character = character;
        }

        public void Draw()
        {
            Console.Write(this._character);
        }
    }


}
