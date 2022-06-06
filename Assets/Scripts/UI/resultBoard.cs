using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultBoard : MonoBehaviour
{
    public GameObject stageObj;
    AudioSource audio;
    public GameObject extObj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showResultBoard());
        
        audio = this.GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator showResultBoard()
    {

        if (stageObj != null)
        {
            stageObj.SetActive(true);
        }
        
        yield return new WaitForSeconds(2.0f);
        
        stageObj.SetActive(false);
        
        this.gameObject.SetActive(false);
    }
}
