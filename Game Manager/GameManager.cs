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

        public void Update(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    this._player.Move(Direction.Up);
                    break;
                case ConsoleKey.A:
                    this._player.Move(Direction.Left);
                    break;
                case ConsoleKey.S:
                    this._player.Move(Direction.Down);
                    break;
                case ConsoleKey.D:
                    this._player.Move(Direction.Right);
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            //Console.Clear();

            if (this._map.hasChanged)
                this._map.Draw();

            this._player.Draw();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("PosX: " + this._player.PosX + " PosY: " + this._player.PosY);
        }
    }
}


