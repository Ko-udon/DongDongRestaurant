using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer2 : MonoBehaviour
{
    public Text text;
    public float totalTime;
    public float time = 0.0f;
    public GameObject failImg;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        text.text = "≈∏¿Ã∏”: " + ((int)totalTime - (int)time) + " S";
        if (((int)totalTime - (int)time) < 1)
        {
            
            failImg.SetActive(true);

        }

        
    }
}
