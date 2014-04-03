﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Screen
    {
        public bool isActive = true;

        public virtual void Draw()
        {
            while (this.isActive)
            {
                Console.WriteLine("Missing Menu...");
                this.PressAnyKey();
            }
        }

        protected void OutputTitle(string title)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--           {0}\t\t\t--", title);
            Console.WriteLine("--------------------------------------------------");
        }

        protected void PressAnyKey()
        {
            Console.WriteLine("--      Press any key to continue               --");
            Console.WriteLine("--------------------------------------------------");
        }
    }

    class MainMenu : Screen
    {
        public override void Draw()
        {
            this.OutputTitle("Welcome to Scourge");
            Console.WriteLine("--                                              --");
            Console.WriteLine("--       Created By: 0x539                      --");
            Console.WriteLine("--       Twitter: @Aaronought                   --");
            Console.WriteLine("--------------------------------------------------");
            this.PressAnyKey();
        }
    }
    class StatsScreen : Screen
    {
        private Player _player;

        public StatsScreen(Player player)
        { 
            this._player = player;
        }
        public override void Draw()
        {
            this.isActive = false;
            this.OutputTitle(this._player.Name + "'s Stats");
            Console.WriteLine("--       Strength:       {0}\t\t\t--", this._player.Strength);
            Console.WriteLine("--       Dexterity:      {0}\t\t\t--", this._player.Dexterity);
            Console.WriteLine("--       Intelligence:   {0}\t\t\t--", this._player.Intelligence);
            Console.WriteLine("--       Endurance:      {0}\t\t\t--", this._player.Endurance);
            Console.WriteLine("--       Luck:           {0}\t\t\t--", this._player.Luck);
            Console.WriteLine("--                          \t\t\t--");
            Console.WriteLine("--------------------------------------------------");
            this.PressAnyKey();
        }
    }

    class GameScreen : Screen
    {
        GameManager _gm;

        public GameScreen(GameManager gm) 
        {
            this._gm = gm;
        }

        public override void Draw()
        {
            Console.WriteLine("Game Screen Here!!");
        }
    }
}