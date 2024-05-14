using System.Collections;
using System.Collections.Generic;
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

    void stockUp()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            
            Item item = (Item)cheeses[Random.Range(0, cheeses.Length)];
            shopItemPrefab.updateItem(item);
            Instantiate(shopItemPrefab, slots[i].transform);

        }
    }

    
    void Update()
    {
        
    }
}
