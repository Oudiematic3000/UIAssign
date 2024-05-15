using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeep : MonoBehaviour
{
    public Speechbub speechbub;
    public GameObject CHEESE;
 
    private void OnMouseDown()
    {
        
        
            speechbub.speak(8);
           CHEESE.SetActive(true);
        
    }
}
