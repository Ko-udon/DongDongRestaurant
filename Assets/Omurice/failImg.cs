using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failImg : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> gameObj;

    void Start()
    {
        for(int i=0;i<gameObj.Count;i++)
        {
            gameObj[i].SetActive(false);
        }
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
