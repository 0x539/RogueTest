using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class ScreenManager
    {
        public int _menuIndex = 0;
        Screen[] _menus;
        GameManager _gm;
        Player _player;

        public ScreenManager(GameManager gm)
        {
            this._gm = gm;
            this._player = this._gm.Player;
            

            this._menus = new Screen[2];
            this._menus[0] = new StatsScreen(this._player);
            this._menus[1] = new GameScreen(this._gm);
        }

        public void Draw(ConsoleKey key)
        {
            Console.Clear();
            for (int x = 0; x < this._menus.Count(); x++)
            {
                if (this._menus[x].isActive)
                {
                    this._menus[x].Draw();
                    break;
                }
            }

        }

        public void Update(GameManager gm)
        {
            //Take in the new game manager.
            this._gm = gm;
            this._player = this._gm.Player;
        }

        public static void DrawMainMenu()
        {
            new MainMenu().Draw();
        }
    }
}
