using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeClickable : MonoBehaviour
{
    public Button shortB;
    public Button longB;
    public Button btn;

    void Update()
    {
        if (!(shortB.interactable) && !(longB.interactable))
        {
            btn.interactable = true;
        }
    }
}
