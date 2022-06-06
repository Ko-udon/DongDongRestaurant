using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitBtn : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clickExit()
    {
        audio.Play();
        Application.Quit();
    }
}
