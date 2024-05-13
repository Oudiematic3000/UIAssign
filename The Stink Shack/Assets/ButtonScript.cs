using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject inventory;
    public ItemPrefabScript itemPrefab;
    public Item cheddar;
     void Start()
    {
      
    }
    public void openPack()
    {
        inventory.SetActive(!inventory.activeSelf);
    }

    public void makeCheese()
    {
        Instantiate(itemPrefab);
        itemPrefab.updateItem(cheddar);
    }
}
