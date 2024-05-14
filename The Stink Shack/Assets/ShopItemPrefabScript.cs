using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopItemPrefabScript : MonoBehaviour
{
    public int itemID;
    public string itemName;
    public string flavourText;
    public Item item;

    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI price;

    public InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryManager>();
    }

    

    public void updateItem(Item item)
    {
        this.item = item;
        itemID = item.itemID;
        spriteRenderer.sprite = item.sprite;
        itemName = item.itemName;
        flavourText = item.flavourText;
        price.text = "$"+item.price.ToString();
      
    }

    private void OnMouseDown()
    {
        inventoryManager.addInv(item);
    }
}
