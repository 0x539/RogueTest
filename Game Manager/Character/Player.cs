using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Player
    {
        private string _name;
        private short _positionX;
        private short _positionY;
        private Inventory _inventory;
        private Random _rnd;

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
        }
        public short PosY
        {
            get { return this._positionY; }
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
        public Player()
        {
            this._rnd = new Random();
            this.Name = "";
            this._positionX = 1;
            this._positionY = 1;
            this.InitialiseStats();
        }
        
        public Player(short x, short y)
        {
            this._rnd = new Random();
            this.Name = "";
            this._positionX = x;
            this._positionY = y;
            this.InitialiseStats();
        }
        public Player(string name, short x, short y)
        {
            this._rnd = new Random();
            this.Name = name;
            this._positionX = x;
            this._positionY = y;
            this.InitialiseStats();
        }
        #endregion

        private void InitialiseStats()
        {
            this._str = this._rnd.Next(0, 100);
            this._dex = this._rnd.Next(0, 100);
            this._int = this._rnd.Next(0, 100);
            this._end = this._rnd.Next(0, 100);
            this._luc = this._rnd.Next(0, 100);
        }
    }
}
