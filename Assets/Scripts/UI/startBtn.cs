using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBtn : MonoBehaviour
{
    public GameObject startUI;
    public GameObject startText;
    public GameObject lfImage;
       public GameObject rgImg;
    AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
    }

   
    

    public void OnClick()
    {
        audio.Play();
        startText.SetActive(true);
        lfImage.SetActive(false);
        rgImg.SetActive(false);
        //StartCoroutine(WaitForIt());
        startUI.SetActive(false);

    }
}
