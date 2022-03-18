using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest6 : MonoBehaviour
{
    public Slider s1;
    public Slider s2;
    public Slider s3;
    public Slider s4;
    public Slider s5;
    public Slider s6;
    public Slider s7;
    public Slider s8;

    public void quest6()
    {
        Controller.instance.addAnhedoniaS((int)s1.value);
        Controller.instance.addAnhedoniaS((int)s2.value);
        Controller.instance.addAnhedoniaS((int)s3.value);
        Controller.instance.addAnhedoniaS((int)s4.value);
        Controller.instance.addAnhedoniaS((int)s5.value);
        Controller.instance.addAnhedoniaS((int)s6.value);
        Controller.instance.addAnhedoniaS((int)s7.value);
        Controller.instance.addAnhedoniaS((int)s8.value);
    }
}
