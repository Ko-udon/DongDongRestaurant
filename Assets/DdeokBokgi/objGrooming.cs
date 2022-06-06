using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objGrooming : MonoBehaviour
{
    public int value;
    source source;
    AudioSource audio;

    private void Start()
    {
        source = GameObject.Find("Dish").GetComponent<source>();
        audio = this.GetComponent<AudioSource>();

    }

    // Start is called before the first frame update
    public void OnEnter()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x * 1.5f, this.transform.localScale.y * 1.5f, this.transform.localScale.z * 1.5f);
    }
    public void OnEnd()

    {
        audio.Play();
        this.transform.localScale = new Vector3(this.transform.localScale.x / 1.5f, this.transform.localScale.y / 1.5f, this.transform.localScale.z / 1.5f);
    }
    public void OnClick()
    {
        source.MixedSource(value);
        audio.Play();
        this.gameObject.SetActive(false);
    }
}
