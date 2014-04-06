using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Game
    {
        bool isActive = true;

        ScreenManager _sm;
        GameManager _gm;
        ConsoleKey _key;

        public Game()
        {
            this._gm = new GameManager();
            this._sm = new ScreenManager(this._gm);

            Console.CursorVisible = false;
        }

        public void Run()
        {
            while (this.isActive) 
            {
                //Then update the screen manager with the updated game manager
                //This should then mean what is drawn to the screen is up-to-date
                //Probably should update game manager.
                this._gm.Update(this._key);
                this._sm.Update(this._gm);
                this._sm.Draw();

                this._key = Console.ReadKey().Key;

                if (this._key == ConsoleKey.Escape)
                {
                    this.isActive = false;
                }
            }
        }
    }
}
