using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class Pan : MonoBehaviour

{

    Vector3 defaultPos;

    public Camera arCamera;
    Touch touch;

    public static Vector2 defaultposition;
    
    public void StartTouch()
    {
        //Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    
    }

    public void endTouch()
    {

    }
    void Start()
    {
        //defaultPos = this.transform.position;    
    }
    void Update()
    {
        //Touch touch = Input.GetTouch(0);

        float halfW = Screen.width / 2;
        float halfH = Screen.height / 2;


        /*transform.position = new Vector3((Touch.position.x-halfW)/(halfW), 
            (transform.position.y-halfH)/halfH, 0f);*/


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                this.transform.position = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                this.transform.position = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                this.transform.position = defaultPos;
            }
        }
    }

}
