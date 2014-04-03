using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueTest
{
    class Item
    {
        ItemSlot _slot = ItemSlot.None;
        ItemRarity _rarity = ItemRarity.Junk;
    }

    [Flags]
    enum ItemRarity
    {
        Junk, Common, Uncommon, Rare, Epic, Legendary, Artifact
    }

    [Flags]
    enum ItemSlot
    {
        Head, Back, Chest, Hands, Legs, Feet, None
    }
}
