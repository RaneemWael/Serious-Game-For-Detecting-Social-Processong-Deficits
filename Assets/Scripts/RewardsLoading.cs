using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardsLoading : MonoBehaviour
{
    public GameObject textDots;
    public GameObject text;

    void Start()
    {
        Invoke("delay", 20.0f);
    }
    void delay()
    {
        textDots.SetActive(false);
        text.SetActive(true);
    }

}