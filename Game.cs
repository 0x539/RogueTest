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

        public Game()
        {
            this._gm = new GameManager();
            this._sm = new ScreenManager(this._gm);

            Console.CursorVisible = false;
        }

        public void Run()
        {
            ScreenManager.DrawMainMenu();

            while (this.isActive) 
            {
                //Probably should update game manager.
                this._gm.Update();
                this._sm.Update(this._gm);

                //Then update the screen manager with the updated game manager
                //This should then mean what is drawn to the screen is up-to-date

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    this.isActive = false;
                }
                else
                {
                    this._sm.Draw(key.Key);
                }
            }
        }
    }
}
