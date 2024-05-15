using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseButtonScript : MonoBehaviour
{
    public GameObject shopkeep;
    public Canvas canvas;
    public Canvas canvas2;
    public Canvas canvas3;
    public Door door;
    public ChestButton chestButton;
    public void toHouse()
    {
       shopkeep.SetActive(false);
        canvas.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(false);
        canvas3.gameObject.SetActive(true);
        door.gameObject.SetActive(true);
        chestButton.gameObject.SetActive(true);
    }
}
