using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kettle : MonoBehaviour
{
    private void Start()
    {

        this.transform.localRotation= Quaternion.Euler(new Vector3(0f, 0f, 0f));

    }
    public void kettleSetDown()
    {
        this.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 50f));
    }
    public void kettleSetUp()
    {
        this.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
    }
}
