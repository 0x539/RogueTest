using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class GameManager
    {
        #region Variables
        bool isActive = true;

        Map _map = new Map();
        Player _player;
        #endregion

        #region Get / Setters
        public Player Player
        {
            get { return this._player; }
        }
        #endregion

        public GameManager()
        {
            this._player = new Player();
        }

        public void Update()
        {
            //Update the player
        }

        public void Draw()
        {
            Console.Clear();

            this._map.draw();
        }
    }
}


