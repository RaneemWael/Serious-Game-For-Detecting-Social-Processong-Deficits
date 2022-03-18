using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reactResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    {
        s.value = (float) Controller.instance.countReactIssueS / 12.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of you \nexhibiting such a trait. You are a person that is able to act \ncorrectly upon what they believe. You tend to think your \ndecisions and actions thoroughly before taking/doing them."; 
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is a possibility of you exhibiting \nsuch a trait. You are a person that tends to act and take \ndecisions impulsively rather than think them through. You \ndon't follow through on what you believe or on the series of \nevents that took place.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of you \nexhibiting such a trait. You are a person that tends to act \nand take decisions impulsively rather than think them \nthrough. You don't follow through on what you believe or on the \nseries of events that took place.";
        }
    }
}
