using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public InventoryManager inventory;
    public SpriteRenderer invSprite;
    public Item cheddar;
    private bool isOpen = false;
    public Button button;
    public Object[] bagSprites;
    public Shopkeep shopkeep;
     void Start()
    {
      bagSprites = Resources.LoadAll("BagButton", typeof(Sprite));
        invSprite = inventory.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (isOpen)
        {
            button.image.sprite = (Sprite)bagSprites[1];
            shopkeep.GetComponent<PolygonCollider2D>().enabled = false;
        }    else 
        {
            button.image.sprite = (Sprite)bagSprites[0];
            if (shopkeep.colOn)
                shopkeep.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
    public void openPack()
    {
        invSprite.enabled = !invSprite.enabled;
        isOpen=!isOpen;
    }

   
}
