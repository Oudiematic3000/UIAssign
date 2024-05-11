using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName ="New Cheese", menuName ="Cheese")]
public class Item : ScriptableObject 
{
    public int itemID;
    public string flavourText;
    public Sprite sprite;
    public string itemName;

}
