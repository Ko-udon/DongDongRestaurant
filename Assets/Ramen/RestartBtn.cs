using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartBtn : MonoBehaviour
{
    
    public Canvas stageCanvas;
    private Canvas tmpStageObj;
    // Start is called before the first frame update
    void Start()
    {
        tmpStageObj = stageCanvas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnClick()
    {
        Instantiate(tmpStageObj);
        stageCanvas.gameObject.SetActive(false);
        
    }
}
