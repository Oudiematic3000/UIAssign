using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StackPrefabScript : MonoBehaviour
{


    public int quantity = 1;
    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI quantityText;
    public Item item;
    public InventoryManager inventoryManager;
    public Camera cam;

    private void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }


    private void Update()
    {


        if (inventoryManager.GetComponent<SpriteRenderer>().isVisible)
        {

            spriteRenderer.enabled = true;
            gameObject.GetComponentInChildren<Canvas>().enabled = true;
            gameObject.GetComponentInChildren<Canvas>().overrideSorting = true;

        }
        else
        {

            spriteRenderer.enabled = false;
            gameObject.GetComponentInChildren<Canvas>().enabled = false;

        }

        if (quantity < 1)
        {
            Destroy(gameObject);
        }
        if (quantity == 1)
        {
            quantityText.enabled = false;
        }
        else
        {
            quantityText.enabled = true;
        }
        quantityText.text = quantity.ToString();
    }

    public void updateStack(Item i)
    {
        item = i;
        spriteRenderer.sprite = item.sprite;
        
    }

    private void OnMouseDrag()
    {
        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 pos = Camera.main.ScreenToWorldPoint(screenPoint);
        transform.position = new Vector3(pos.x, pos.y, 0);

    }

    private void OnTriggerStay(Collider other)
    {
        transform.position = other.transform.position;
        Debug.Log("touching");
    }
}
