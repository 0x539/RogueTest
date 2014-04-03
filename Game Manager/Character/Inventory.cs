using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Inventory
    {
        private Item[] _backpack;

        //These should probably have a child class of item.
        //Or could do the check at get/setter stage.
        private Item _head;
        private Item _back;
        private Item _chest;
        private Item _hands;
        private Item _legs;
        private Item _feet;

        public Inventory()
        {

        }
    }
}
