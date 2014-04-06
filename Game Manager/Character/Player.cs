using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Player
    {
        private string _name;

        //Positions
        private short _positionX;
        private short _positionY;
        private short _mapPosX;
        private short _mapPosY;
        private Inventory _inventory;
        private Random _rnd;
        private Map _map;

        public string Name
        {
            get { return this._name; }
            set
            {
                if (value == "")
                {
                    this._name = "No Name";
                }
                else
                {
                    this._name = value;
                }
            }
        }
        public short PosX
        {
            get { return this._positionX; }
            set
            {
                if (value >= 0 && value < this._map.MaxX && this._map.map2[this._positionY, value].isHabitable)
                {
                    this._positionX = value;
                }
            }
        }
        public short PosY
        {
            get { return this._positionY; }
            set
            {
                if (value >= 0 && value < this._map.MaxY && this._map.map2[value, this._positionX].isHabitable)
                {
                    this._positionY = value;
                }
            }
        }
        public Inventory Inventory
        {
            get { return this._inventory; }
        }

        #region Stats
        /* Stats */
        int _str;
        int _dex;
        int _int;
        int _end;
        int _luc;

        #region get/setters
        public int Strength
        {
            get { return this._str; }
            set { this._str = value; }
        }
        public int Dexterity
        {
            get { return this._dex; }
            set { this._dex = value; }
        }
        public int Intelligence
        {
            get { return this._int; }
            set { this._int = value; }
        }
        public int Endurance
        {
            get { return this._end; }
            set { this._end = value; }
        }
        public int Luck
        {
            get { return this._luc; }
            set { this._luc = value; }
        }
        #endregion

        /* Stats END */
        #endregion

        #region Constructors
        public Player(Map map)
        {
            this._map = map;
            this._rnd = new Random();
            this.Name = "";
            this._positionX = 1;
            this._positionY = 1;
            this.InitialiseStats();
        }
        #endregion

        public void Draw()
        {
            Console.SetCursorPosition(this._positionX, this._positionY);
            Console.Write("1");
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    this.PosY--;
                    break;
                case Direction.Down:
                    this.PosY++;
                    break;
                case Direction.Left:
                    this.PosX--;
                    break;
                case Direction.Right:
                    this.PosX++;
                    break;
                default:
                    break;
            }
        }

        private void InitialiseStats()
        {
            this._str = this._rnd.Next(0, 100);
            this._dex = this._rnd.Next(0, 100);
            this._int = this._rnd.Next(0, 100);
            this._end = this._rnd.Next(0, 100);
            this._luc = this._rnd.Next(0, 100);
        }
    }

    [Flags]
    public enum Direction
    {
        Up, Down, Left, Right
    }
}
