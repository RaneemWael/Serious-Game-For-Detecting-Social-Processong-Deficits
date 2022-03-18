using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mentalResults : MonoBehaviour
{
    public Slider s;

    void Start()
    {
        s.value = ((float)Controller.instance.countTrustIssueS + (float)Controller.instance.countReactIssueS) / 24.0f;
    }
}
