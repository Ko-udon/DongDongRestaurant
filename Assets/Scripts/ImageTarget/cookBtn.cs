using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookBtn : MonoBehaviour
{
    public GameObject gameStartText;
    public GameObject targetImg;
    public GameObject playUI;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
        if (gameStartText==null)
        {
            gameStartText = GameObject.FindGameObjectWithTag("GameStartText");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        audio.Play();
        gameStartText.SetActive(false);
        targetImg.SetActive(false);
        playUI.SetActive(true);
        //gameStart
        this.gameObject.SetActive(false);
    }
}
