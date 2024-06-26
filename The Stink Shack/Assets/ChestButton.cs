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
    public UpgradeButton upgradeButton;
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
            upgradeButton.gameObject.SetActive(true);
        }
        else
        {
            button.image.sprite = (Sprite)chestSprites[0];
            upgradeButton.gameObject.SetActive(false);
        }
    }
    public void openChest()
    {
        chestSprite.enabled = !chestSprite.enabled;
        chest.gameObject.SetActive(true);
        isOpen = !isOpen;
    }
}

