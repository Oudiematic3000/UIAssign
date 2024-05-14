using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public SlotScript[] slots;
    public Object[] cheeses;
    public StackPrefabScript stackPrefab;


    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
     
    }

    public void addInv(Item item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (!slots[i].isOccupied)
            {
                slots[i].isOccupied = true;
                stackPrefab.updateStack(item);
                Instantiate(stackPrefab, slots[i].transform);
                
                return;
            }
            else
            {
                
            }
        }
    }


    void Update()
    {

    }
}
