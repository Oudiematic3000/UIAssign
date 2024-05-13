using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemPrefabScript : MonoBehaviour
{
    public int itemID;
    public string itemName;
    public string flavourText;

    public SpriteRenderer spriteRenderer;

    public void updateItem(Item item)
    {
        itemID = item.itemID;
        spriteRenderer.sprite = item.sprite;
        itemName = item.itemName;
        flavourText = item.flavourText;
    }
}
