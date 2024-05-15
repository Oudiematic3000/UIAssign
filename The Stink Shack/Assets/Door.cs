using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject shopkeep;
    public Canvas canvas;
    public Canvas canvas2;
    public Canvas canvas3;
    public HouseButtonScript houseButton;
    public ChestButton chestButton;
    public ChestManager chestManager;
    public InventoryManager inventoryManager;
    public ShopManager shopManager;
    public GameObject sellspace;
    public Speechbub speechbub;

    public PolygonCollider2D polygonCollider2D;
    private void OnMouseDown()
    {
        
          shopkeep.SetActive(true);
        canvas.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(true);
        canvas3.gameObject.SetActive(false);
        houseButton.gameObject.SetActive(true);
        chestButton.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        chestManager.gameObject.SetActive(false);
        sellspace.SetActive(true);
        speechbub.gameObject.SetActive(true);
        shopManager.stockUp();
        
    
}
    private void Update()
    {
        if(inventoryManager.GetComponent<SpriteRenderer>().isVisible) { 
        polygonCollider2D.enabled = false;
        }
        else
        {
            polygonCollider2D.enabled = true;
        }
    }
}
