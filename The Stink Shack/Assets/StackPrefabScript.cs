using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StackPrefabScript : MonoBehaviour
{
    
    
    public int quantity=1;
    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI quantityText;
    public Item item;
    public InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        updateStack(item);
    }


    private void Update()
    {


        if (inventoryManager.GetComponent<SpriteRenderer>().isVisible)
        {
            
            spriteRenderer.enabled = true;
            gameObject.GetComponentInChildren<Canvas>().enabled = true;
            gameObject.GetComponentInChildren<Canvas>().overrideSorting = true;

        }
        else
        {
            
            spriteRenderer.enabled = false;
            gameObject.GetComponentInChildren<Canvas>().enabled = false;

        }

        if (quantity < 1)
        {
            Destroy(gameObject);
        }
        quantityText.text = quantity.ToString();
    }

    public void updateStack(Item i)
    {
        item = i;
        spriteRenderer.sprite = item.sprite;
    }
}
