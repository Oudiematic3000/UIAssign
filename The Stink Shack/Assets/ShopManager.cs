using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public SlotScript[] slots;
    public SlotScript[] exoticSlots;
    public Object[] cheeses;
    public ShopItemPrefabScript shopItemPrefab;
    


    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
        stockUp();
        stockUpExotic();
    }

    public void stockUp()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (!slots[i].isOccupied)
            {
                Item item = (Item)cheeses[Random.Range(5, cheeses.Length)];
                shopItemPrefab.updateItem(item);
                ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, slots[i].transform);
                spwnCheese.AddComponent<PolygonCollider2D>();
            }
        }
    }

    public void stockUpExotic()
    {
        for (int i = 0; i < exoticSlots.Length; i++)
        {
            if (!exoticSlots[i].isOccupied)
            {
                Item item = (Item)cheeses[i];
                shopItemPrefab.updateItem(item);
                ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, exoticSlots[i].transform);
                spwnCheese.AddComponent<PolygonCollider2D>();
            }
        }
    }


    public void reAdd(Item item, int q)
    {

        if (item.itemID > 4)
        {

            for (int i = 0; i < slots.Length; i++)
            {
                if (!slots[i].isOccupied)
                {
                    shopItemPrefab.updateItem(item);
                    ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, slots[i].transform);
                    spwnCheese.AddComponent<PolygonCollider2D>();
                    return;
                }

            }
        }
        else
        {
            for (int i = 0; i < exoticSlots.Length; i++)
            {
                if (!exoticSlots[i].isOccupied)
                {
                    shopItemPrefab.updateItem(item);
                    ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, exoticSlots[i].transform);
                    spwnCheese.AddComponent<PolygonCollider2D>();
                    return;
                }

            }
        }
        }
    
}
