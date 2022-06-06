using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireControl2 : MonoBehaviour
{
    public GameObject fireImg;
    public bool isclick;
    //public Vector3 targetPosition;

    public AudioSource audio;


    
    private float time;
    private bool isTime;

    public GameObject clearBoard;
    public GameObject failBoard;


    public Image gaze;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isclick)
        {
            fireImg.gameObject.SetActive(true);
            time += 0.1f*Time.deltaTime;
            gaze.fillAmount = time;
        }
        else if(isclick==false)
        {
            fireImg.gameObject.SetActive(false);
        }

    }
    public void CheckClear()
    {
        //ramenImg.SetActive(false);
        Debug.Log(1);
        if (0.5f < gaze.fillAmount && 0.6f > gaze.fillAmount)
        {
            clearBoard.SetActive(true);
        }
        else
        {
            failBoard.SetActive(true);
        }
    }
    public void bgnClick()
    {
        audio.Play();
        isTime = true;
        isclick = true;

    }
    public void endClick()
    {
        audio.Stop();
        isTime = false;
        isclick = false;
        CheckClear();
    }
}
