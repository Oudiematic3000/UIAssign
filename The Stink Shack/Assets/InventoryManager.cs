using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
               StackPrefabScript spwnCheese= Instantiate(stackPrefab, slots[i].transform);
                spwnCheese.AddComponent<PolygonCollider2D>();

                return;
            }
        }
    }


    void Update()
    {

    }
}
