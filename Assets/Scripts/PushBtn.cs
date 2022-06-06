using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PushBtn : MonoBehaviour
{
    kettle kettle;
    public GameObject waterImg;
    public GameObject ramenImg;

    public GameObject clearImg;
    public GameObject failImg;

    private bool isClick = false;
    AudioSource audio;
    public Image gazeImg;

    // Start is called before the first frame update
    void Start()
    {
        kettle = GameObject.Find("kettle").GetComponent<kettle>();
        audio = this.GetComponent<AudioSource>();

        failImg.SetActive(false);
        gazeImg.fillAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClick)
        {
            gazeImg.fillAmount += 0.1f*Time.deltaTime;
        }
    }
    public void WhileClick()
    {
        isClick = true;
        kettle.kettleSetDown();
        waterImg.SetActive(true);
        audio.Play();
    }

    public void WhileExit()
    {
        isClick = false;
        kettle.kettleSetUp();
        waterImg.SetActive(false);
        audio.Stop();
        CheckClear();
    }

    public void CheckClear()
    {
        //ramenImg.SetActive(false);
        if(0.85f<gazeImg.fillAmount&&0.89f>gazeImg.fillAmount)
        {
            clearImg.SetActive(true);
        }
        else
        {
            failImg.SetActive(true);
        }
    }
}
