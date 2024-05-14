using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public SlotScript[] slots;
    public Object[] cheeses;
    public StackPrefabScript stackPrefab;
    private bool foundItem=false;
    public Player player;

    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
     
    }

    public void addInv(Item item)
    {
        foundItem = false;
        
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].isOccupied)
            {

                if (slots[i].GetComponentInChildren<StackPrefabScript>().item == item)
                {
                    slots[i].GetComponentInChildren<StackPrefabScript>().quantity++;
                    player.money -= item.price;
                    foundItem = true;
                    return;
                    
                }

            }

        }
        if (!foundItem)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (!slots[i].isOccupied)
                {
                    stackPrefab.updateStack(item);
                    StackPrefabScript spwnCheese = Instantiate(stackPrefab, slots[i].transform);
                    spwnCheese.AddComponent<PolygonCollider2D>();
                    player.money -= item.price;
                    return;
                }
            }

            
        }
    }


    void Update()
    {

    }
}
