using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI flavourText;
    private void Start()
    {
      
        
    }
    void Update()
    {
        
            Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(screenPoint);
            transform.position = new Vector3(pos.x, pos.y+1, 1);
        
    }

    
}
