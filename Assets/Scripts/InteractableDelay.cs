using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableDelay : MonoBehaviour
{
    public Button b;
    public GameObject textDots;
    public GameObject textB;

    void Start()
    {
        b.interactable = false;
        Invoke("delay", 20.0f);
    }
    void delay()
    {
        textDots.SetActive(false);
        textB.SetActive(true);
        b.interactable = true;
    }

}
