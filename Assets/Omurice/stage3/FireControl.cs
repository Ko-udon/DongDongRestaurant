using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireControl : MonoBehaviour
{
    public GameObject fireImg;
    public bool isclick;
    public Vector3 targetPosition;

    public AudioSource audio;

 
    public List<GameObject> resultImg;
    private float time;
    private bool isTime;

    public GameObject resultBoard;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTime)
        {
            time = time + Time.deltaTime;
        }
        if(isclick==true)
        {
            fireImg.gameObject.SetActive(true);
            
        }
        else
        {
            fireImg.gameObject.SetActive(false);
        }
        
        if(time>2f)
        {
            resultImg[0].SetActive(true);
        }
        if (time > 6f)
        {
            resultImg[1].SetActive(true);
        }
        if (time > 10f)
        {
            resultImg[2].SetActive(true);
            resultBoard.SetActive(true);

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
    }
}
