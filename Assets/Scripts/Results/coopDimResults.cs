using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coopDimResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    {
        s.value = (float)Controller.instance.countCooperationDimS / 30.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of you \nexhibiting such a trait. You are a person who likes to help \n/work with others so you could all reach common success.";
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is a possibility of you exhibiting \nsuch a trait. Your actions relate to those of a person who \nprefers to benefit solely rather than help/work with others.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of you \nexhibiting such a trait. Your actions relate to those of a \nperson who prefers to benefit solely rather than help/work with others.";
        }
    }
}
