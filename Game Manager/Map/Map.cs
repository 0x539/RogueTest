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
        string[] map;

        Tile[][] map2;

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
        }

        public void draw()
        {
            foreach (string s in this.map) {
                Console.WriteLine(s);
            }

            Console.WriteLine("Top: " + Console.CursorTop);
            Console.WriteLine("Left: " + Console.CursorLeft);

            Console.SetCursorPosition(10, 1);
            Console.Write("1");
        }
    }
}
