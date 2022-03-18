using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderText : MonoBehaviour
{
    public Slider s;

    void Update()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int) (value * 100.0f);
        gameObject.GetComponent<Text>().text = "" + val + "";
    }
}
