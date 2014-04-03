using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class GameManager
    {
        bool isActive = true;

        Map _map = new Map();
        Player _player;
        public Player Player
        {
            get { return this._player; }
        }

        public GameManager()
        {
            this._player = new Player();
        }

        public void Update()
        {
            //Update the player
        }

        public void run()
        {

            while (this.isActive) {
                Console.Clear();

                this._map.draw();

                Console.WriteLine();

                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Press any key to continue...");
            }

        }

    }
}


