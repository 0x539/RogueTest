using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * #    =   Wall
 * -    =   Clear / Road
 * =    =   Door
 * ^    =   Tree
 * X    =   Enemy
 * N    =   NPC
 * 1    =   Player1
 */

namespace RogueTest
{
    class Map
    {
        public bool hasChanged = true;

        string[] map;

        public Tile[,] map2;

        public int MaxX;
        public int MaxY;

        public Map()
        {
            //this.map2 = new Tile[][] {
            //    { new Tile() }
            //};
            this.map = new string[] {
                "####################",
                "#------------------#",
                "#----^-------------#",
                "#------------------#",
                "#------------^-----#",
                "#-----^------------#",
                "#-----------^------#",
                "#-------#NN#---X---#",
                "#-------#--#-------#",
                "#########==#########",
            };


            this.MaxX = 20;
            this.MaxY = this.map.Count();
            this.map2 = new Tile[this.map.Count(), 20];

            int x = 0;
            int y = 0;
            foreach (string s in this.map)
            {
                x = 0;
                foreach (char c in s)
                {
                    this.map2[y, x] = new Tile(c);
                    x++;
                }
                y++;
            }
        }

        public void Draw()
        {
            for (int x = 0; x < this.map2.GetLength(0); x++)
            {
                for (int y = 0; y < this.map2.GetLength(1); y++)
                {
                    this.map2[x, y].Draw();
                }
                Console.WriteLine();
            }
            this.hasChanged = false;
        }
    }
}
