using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    public List<GameObject> obj;
    public List<GameObject> resultObj;
    public int cnt;

    public GameObject playBoard;
    private AudioSource audio;
    public GameObject resultBoard;

    public GameObject nextGame;
    public int clicklimit;

    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
        resultObj[3].SetActive(false);
        resultObj[2].SetActive(false);
        resultObj[1].SetActive(false);
        resultObj[0].SetActive(false);
        //cnt = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator showresultBoard()
    {
        resultBoard.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        nextGame.SetActive(true);
        playBoard.SetActive(false);
        resultBoard.SetActive(false);
    }
    public void OnClick()
    {
        cnt--;
        audio.Play();
        if(cnt==7)
        {
            resultObj[3].SetActive(true);
        }
        else if(cnt == 5)
        {
            resultObj[2].SetActive(true);
        }
        else if (cnt == 3)
        {
            resultObj[1].SetActive(true);
        }
        else if (cnt == 1)
        {
            resultObj[0].SetActive(true);
        }

        obj[cnt].SetActive(false);

        

        if (cnt == 0)
        {
            StartCoroutine(showresultBoard());
        }
    }

    public void OnClick2()
    {
        cnt--;
        audio.Play();
        obj[cnt].SetActive(false);

        if (cnt==clicklimit/2)
        {
            resultObj[3].SetActive(true);
        }
        else if(cnt==clicklimit/3)
        {
            resultObj[2].SetActive(true);
        }
        else if(cnt== clicklimit / 4
            )
        {
            resultObj[1].SetActive(true);
        }
        else if (cnt == 1)
        {
            resultObj[0].SetActive(true);
        }

        if (cnt == 0)
        {
            StartCoroutine(showresultBoard());
        }
        
    }
}
