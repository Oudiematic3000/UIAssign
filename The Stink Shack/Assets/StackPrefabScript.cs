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
    public SpriteRenderer invSprite;
    public Camera cam;
    public PolygonCollider2D polygonCollider2D;
    public bool touching;
    private Vector3 iPos;
    private Transform iParent;



    private void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        invSprite =GameObject.Find("Inventory").GetComponent<SpriteRenderer>();
        polygonCollider2D =this.GetComponent<PolygonCollider2D>();
    }


    private void Update()
    {
        if (invSprite.enabled == false)
        {
            polygonCollider2D.enabled = false;
        }
        else
        {
            polygonCollider2D.enabled = true;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

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
        polygonCollider2D = gameObject.GetComponent<PolygonCollider2D>();
        
    }
    private void OnMouseDown()
    {
         iPos= transform.parent.transform.position;
         iParent = transform.parent;
    }
    private void OnMouseDrag()
    {
        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 pos = Camera.main.ScreenToWorldPoint(screenPoint);
        transform.position = new Vector3(pos.x, pos.y, 0);
       

    }
    private void OnMouseUp()
    {
        if (!touching)
        {
            transform.SetParent(iParent);
            transform.position = iPos;
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (!collision.GetComponent<SlotScript>().isOccupied || transform.IsChildOf(collision.transform))
        {
            

        if (collision.GetComponent<SlotScript>() != null)
        {
            transform.SetParent(collision.transform);
            transform.position = collision.transform.position;
            touching = true;
        }
    }
        
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (touching)
        {
            touching = false;
            Debug.Log("Leave");
        }
    }

}
