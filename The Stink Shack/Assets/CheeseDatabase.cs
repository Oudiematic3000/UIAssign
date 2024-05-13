using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseDatabase : MonoBehaviour
{
    public Object[] cheeses;
    void Start()
    {
        cheeses = Resources.LoadAll("Cheeses", typeof(Item));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
