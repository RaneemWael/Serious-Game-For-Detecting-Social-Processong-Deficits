using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punishmentResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    { 
        s.value = (float)Controller.instance.countPunishment / 7.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of you \nexhibiting such a trait. You are a person who would likely \nignore wrong doings of others and rather not confront or call them \nout.";
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is a possibility of you exhibiting \nsuch a trait. Researches have shown that costly punishment \nco-varies with altruistic behavior, which refers to selflessness. \nThis probably means that you'd rather stand up against \nwrong doings than stay silent in order to teach them a lesson.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of you \nexhibiting such a trait. Researches have shown that costly \npunishment co-varies with altruistic behavior, which refers to \nselflessness. This probably means that you'd rather stand up \nagainst wrong doings than stay silent to teach them a lesson.";
        }
    }
}
