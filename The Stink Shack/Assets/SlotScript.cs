using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    public bool isOccupied=false;
    public BoxCollider2D  boxCollider2D;

    private void Update()
    {
        if (transform.childCount > 0)
        {
            isOccupied = true;
        }
        else
        {
            isOccupied = false;
        }
        
      

        
    }

    

}
