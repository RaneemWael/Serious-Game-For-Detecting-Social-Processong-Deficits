using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionHaunted2 : MonoBehaviour
{
    public setController cont;
    public GameObject text;
    public GameObject music;
    public GameObject music2;

    public void OnCollisionEnter()
    { 
        text.SetActive(true);
        music.GetComponent<AudioSource>().Stop();
        music2.GetComponent<AudioSource>().Stop();
        cont.playSounds();
    }
}
