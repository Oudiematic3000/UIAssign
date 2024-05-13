using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public SlotScript[] slots;
    public Object[] cheeses;
    public ItemPrefabScript itemPrefab;


    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
        stockUp();
    }

    void stockUp()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            Instantiate(itemPrefab, slots[i].transform);
            Item item = (Item)cheeses[Random.Range(0, cheeses.Length)];
            itemPrefab.updateItem(item);

        }
    }

    
    void Update()
    {
        
    }
}
