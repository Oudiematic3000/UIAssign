using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeep : MonoBehaviour
{
    public Speechbub speechbub;
    public GameObject CHEESE;
    public PolygonCollider2D polygonCollider2D;
    public bool colOn=true;
 
    private void OnMouseDown()
    {
           speechbub.speak(8);
           CHEESE.SetActive(true);
    }

    private void Update()
    {
        if (!colOn)
        {
            polygonCollider2D.enabled = false;
        }
    }
}
