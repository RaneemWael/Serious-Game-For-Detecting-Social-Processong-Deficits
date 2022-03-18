using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderText10 : MonoBehaviour
{
    public Slider s;

    void Update()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value);
        gameObject.GetComponent<Text>().text = "" + val + "";
    }
}
