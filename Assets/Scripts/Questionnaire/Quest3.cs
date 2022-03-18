using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest3 : MonoBehaviour
{
    public Slider s1;
    public Slider s2;
    public Slider s3;

    public void quest3()
    {
        Controller.instance.addEmpathyRedS((int)s1.value);
        Controller.instance.addEmpathyRedS((int)s2.value);
        Controller.instance.addEmpathyRedS((int)s3.value);
    }
}