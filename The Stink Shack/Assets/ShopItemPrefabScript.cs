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
    public Player player;
    public Tooltip tooltip;

    private void Start()
    {
        inventoryManager = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryManager>();
        player = GameObject.Find("Player").GetComponent<Player>();  
        tooltip = GameObject.Find("Tooltip").GetComponent<Tooltip>();
        
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
        if (player.money >= item.price)
        {
            inventoryManager.addInv(item);
            Destroy(gameObject);
            tooltip.enabled = false;
            tooltip.flavourText.enabled = false;
            tooltip.spriteRenderer.enabled = false;
        }
    }

    private void OnMouseEnter()
    {
        tooltip.enabled = true;
        tooltip.spriteRenderer.enabled=true;
        tooltip.flavourText.enabled = true;
        tooltip.flavourText.text = item.itemName+": \nflavour text: "+item.flavourText;
        
    }

    private void OnMouseExit()
    {
        tooltip.enabled = false;
        tooltip.flavourText.enabled=false;
        tooltip.spriteRenderer.enabled = false;
    }

}
