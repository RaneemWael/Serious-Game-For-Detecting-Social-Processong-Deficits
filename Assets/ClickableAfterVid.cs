using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickableAfterVid : MonoBehaviour
{
    public Button btn;

    void OnEnable()
    {
        Invoke("delay", 2.0f);
    }
    void delay()
    {
        btn.interactable = true;
    }
}
