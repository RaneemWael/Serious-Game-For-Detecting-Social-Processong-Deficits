using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trustResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    {
        s.value = (float) Controller.instance.countTrustIssueS / 12.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of you \nexhibiting such a trait. You are a person that is aware \nof other people's intentions and can understand their thought \nprocesses.";
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is a possibility of you exhibiting \nsuch a trait. You show signs of being a person who isn't \naware of other people's intentions and tend to not be able to guess \ntheir intentions or future behaviours.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of you \nexhibiting such a trait. You show signs of being a person \nwho isn't aware of other people's intentions and tend to not be able \nto guess their intentions or future behaviours.";
        }
    }
}
