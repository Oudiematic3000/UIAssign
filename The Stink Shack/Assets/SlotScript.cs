using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    public bool isOccupied=false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.parent = transform;
        collision.transform.position = transform.position;
        Debug.Log("Workin");
    }

}
