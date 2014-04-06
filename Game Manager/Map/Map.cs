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

        Tile[,] map2;

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



            this.map2 = new Tile[this.map.Count(), 20];

            int x = 0;
            int y = 0;
            foreach (string s in this.map)
            {
                y = 0;
                foreach (char c in s)
                {
                    this.map2[x, y] = new Tile(c);
                    y++;
                }
                x++;
            }

            x = x;
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
