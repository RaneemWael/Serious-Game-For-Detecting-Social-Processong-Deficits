using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionHaunted1 : MonoBehaviour
{
    public setController cont; 
    public GameObject text;
    public GameObject music;

    public void OnCollisionEnter()
    {
        text.SetActive(true);
        cont.pauseSounds();
        music.GetComponent<AudioSource>().Play();
    }
}
