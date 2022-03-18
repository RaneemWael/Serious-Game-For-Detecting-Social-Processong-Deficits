using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class socialResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    {
        s.value = (float)Controller.instance.countAnhedoniaS / 80.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of \nyou exhibiting such a trait. You are a person who would likely \nexpend more effort for greater rewards, have good social \nskills, and enjoy the company of others!";
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is quite a possibility of you \nexhibiting such a trait. Social anhedonia stems from diminished \npositive affect from social contact, rather than heightened \nnegative affect. Socially anhedonic people genuinely prefer \nsolitude, and they report less social skill, contact, \ninterest, and pleasure.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of \nyou exhibiting such a trait. Social anhedonia stems from diminished \npositive affect from social contact, rather than heightened \nnegative affect. Socially anhedonic people genuinely prefer \nsolitude, and they report less social skill, contact, \ninterest, and pleasure.";
        }
    }
}
