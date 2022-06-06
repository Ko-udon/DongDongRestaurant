using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source : MonoBehaviour
{
    public int sourceValue;
    public GameObject clearResultBoard;
    public GameObject failResultBoard;
    public GameObject sourceImg;

    public GameObject playBoard;
    public GameObject nextGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MixedSource(int value)
    {
        sourceValue += value;
    }
    IEnumerator showresultBoard()
    {
        
        yield return new WaitForSeconds(2.0f);
        nextGame.SetActive(true);
        
        clearResultBoard.SetActive(false);
        playBoard.SetActive(false);
        this.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        if(sourceValue==10)
        {
            sourceImg.SetActive(true);
            clearResultBoard.SetActive(true);
            StartCoroutine(showresultBoard());
        }
        else
        {
            failResultBoard.SetActive(true);
        }

    }
}
