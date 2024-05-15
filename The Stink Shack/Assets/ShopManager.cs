using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public SlotScript[] slots;
    public Object[] cheeses;
    public ShopItemPrefabScript shopItemPrefab;


    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
        stockUp();
    }

    public void stockUp()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (!slots[i].isOccupied)
            {
                Item item = (Item)cheeses[Random.Range(0, cheeses.Length)];
                shopItemPrefab.updateItem(item);
                ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, slots[i].transform);
                spwnCheese.AddComponent<PolygonCollider2D>();
            }
        }
    }

    
    public void reAdd(Item item)
    {
        for(int i = 0;i < slots.Length;i++)
        {
            if (!slots[i].isOccupied)
            {
                shopItemPrefab.updateItem(item);
                ShopItemPrefabScript spwnCheese = Instantiate(shopItemPrefab, slots[i].transform);
                spwnCheese.AddComponent<PolygonCollider2D>();
            }
        }
    }
}
