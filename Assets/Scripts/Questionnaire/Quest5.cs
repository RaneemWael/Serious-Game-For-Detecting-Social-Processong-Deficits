using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest5 : MonoBehaviour
{
    public Slider s1;
    public Slider s2;
    public Slider s3;
    public Slider s4;

    public void quest5()
    {
        Controller.instance.addTrustIssueS((int)s1.value);
        Controller.instance.addReactIssueS((int)s2.value);
        Controller.instance.addReactIssueS((int)s3.value);
        Controller.instance.addReactIssueS((int)s4.value);
    }
}
