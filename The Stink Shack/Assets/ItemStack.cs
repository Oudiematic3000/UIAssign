using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStack
{
    public Item item;
    public int quantity;

    public ItemStack(Item i, int q)
    {
        item = i;
        quantity = q;
    }


}


