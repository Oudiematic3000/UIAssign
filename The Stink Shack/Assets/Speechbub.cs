using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speechbub : MonoBehaviour
{
    private float timer = 0;
    public bool talking = false;
    public string[] lines;
    public TextMeshProUGUI textSpeech; 
    void Start()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponentInChildren<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (talking)
        {
            if (timer < 2.5)
            {
                this.GetComponent<SpriteRenderer>().enabled = true;
                this.GetComponentInChildren<Canvas>().enabled = true;
                timer += Time.deltaTime;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().enabled = false;
                this.GetComponentInChildren<Canvas>().enabled = false;
                talking = false;
                timer=0;
            }
        }
    }


    public void speak(int ID)
    {
        textSpeech.text = lines[ID];
        talking=true;
        timer = 0;
    }
}
