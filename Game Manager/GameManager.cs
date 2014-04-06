﻿using System;
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
            this._player = new Player(_map);
        }

        public void Update(ConsoleKey key)
        {
            switch (key)
            {
                //This is grim. Needs a better method.
                case ConsoleKey.W:
                    Console.SetCursorPosition(this._player.PosX, this._player.PosY);
                    this._map.map2[this._player.PosY, this._player.PosX].Draw();
                    this._player.Move(Direction.Up);
                    break;
                case ConsoleKey.A:
                    Console.SetCursorPosition(this._player.PosX, this._player.PosY);
                    this._map.map2[this._player.PosY, this._player.PosX].Draw();
                    this._player.Move(Direction.Left);
                    break;
                case ConsoleKey.S:
                    Console.SetCursorPosition(this._player.PosX, this._player.PosY);
                    this._map.map2[this._player.PosY, this._player.PosX].Draw();
                    this._player.Move(Direction.Down);
                    break;
                case ConsoleKey.D:
                    Console.SetCursorPosition(this._player.PosX, this._player.PosY);
                    this._map.map2[this._player.PosY, this._player.PosX].Draw();
                    this._player.Move(Direction.Right);
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            if (this._map.hasChanged)
                this._map.Draw();

            this._player.Draw();

            Console.SetCursorPosition(0, 24);
            Console.Write("PosX:\t" + this._player.PosX + "\tPosY:\t" + this._player.PosY + "\tPressed Key: ");
        }
    }
}


