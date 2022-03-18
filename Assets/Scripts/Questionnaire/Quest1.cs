using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest1 : MonoBehaviour
{
    public Slider s1;
    public Slider s2;

    public void CoopDimS()
    {
        Controller.instance.addCoopDimS((int)s1.value);
        Controller.instance.addCoopDimS((int)s2.value);
    }
}
