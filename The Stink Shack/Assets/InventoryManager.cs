using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public SlotScript[] slots;
    public Object[] cheeses;
    public StackPrefabScript stackPrefab;
    public Item[] inventory;
    private int index = 0;
    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
     
    }

    public void addInv(Item item)
    {
        for(int i=0; i<inventory.Length; i++)
        {
            if (inventory[i] == item)
            {

            }
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].isOccupied)
            {
                
                if (slots[i].GetComponentInChildren<StackPrefabScript>().item== item) {
                    slots[i].GetComponentInChildren<StackPrefabScript>().quantity++;
                    return;
                }
                
            }
            else
            {
                slots[i].isOccupied = true;
                stackPrefab.updateStack(item);
                Instantiate(stackPrefab, slots[i].transform);

                return;
            }
        }
    }


    void Update()
    {

    }
}
