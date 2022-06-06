
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text text;
    public float totalTime;
    private float time=0.0f;
    public GameObject failImg;

    // Start is called before the first frame update
    void Start()
    {
        //text.text += time.ToString();
        time = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        text.text = "≈∏¿Ã∏”: " + ((int)totalTime-(int)time)+" S";
        if(((int)totalTime - (int)time)<1)
        {
            failImg.SetActive(true);

        }
    }
}
