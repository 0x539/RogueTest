using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class ScreenManager
    {
        public int _menuIndex = 0;
        Screen[] _screens;
        GameManager _gm;
        Player _player;

        public ScreenManager(GameManager gm)
        {
            this._gm = gm;
            this._player = this._gm.Player;
            

            this._screens = new Screen[3];
            this._screens[0] = new InputStatsScreen(this._gm);
            this._screens[1] = new StatsScreen(this._player);
            this._screens[2] = new GameScreen(this._gm);
        }

        public void Draw(ConsoleKey key)
        {
            Console.Clear();
            for (int x = 0; x < this._screens.Count(); x++)
            {
                if (this._screens[x].isActive)
                {
                    this._screens[x].Draw();
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
