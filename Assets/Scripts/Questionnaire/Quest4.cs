using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest4 : MonoBehaviour
{
    public Slider s1;
    public Slider s2;
    public Slider s3;
    public Slider s4;

    public void quest4()
    {
        Controller.instance.addEmpathyRedS((int)s1.value);
        Controller.instance.addEmpathyRedS((int)s2.value);
        Controller.instance.addTrustIssueS((int)s3.value);
        Controller.instance.addTrustIssueS((int)s4.value);
    }
}
