using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseButtonScript : MonoBehaviour
{
    public GameObject shopkeep;
    public Canvas canvas;
    public Canvas canvas2;
    public void toHouse()
    {
       shopkeep.SetActive(false);
        canvas.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(false);
    }
}
