using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestButton : MonoBehaviour
{
    public ChestManager chest;
    public SpriteRenderer chestSprite;
    public bool isOpen = false;
    public Button button;
    public Object[] chestSprites;
    void Start()
    {
        chestSprites = Resources.LoadAll("ChestButton", typeof(Sprite));
        chestSprite = chest.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (isOpen)
        {
            button.image.sprite = (Sprite)chestSprites[1];
        }
        else
        {
            button.image.sprite = (Sprite)chestSprites[0];
        }
    }
    public void openChest()
    {
        chestSprite.enabled = !chestSprite.enabled;
        isOpen = !isOpen;
    }
}

