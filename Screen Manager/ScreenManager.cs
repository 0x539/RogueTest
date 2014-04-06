using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class ScreenManager
    {
        int _currentMenu = 0;
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

        public void Draw()
        {
            this._screens[this._currentMenu].Draw();
        }

        public void Update(GameManager gm)
        {
            //Take in the new game manager.
            this._gm = gm;
            this._player = this._gm.Player;

            if (!this._screens[this._currentMenu].isActive)
            {
                if (this._screens[this._currentMenu].clearScreen)
                    Console.Clear();

                this._currentMenu++;
            }
        }
    }
}
