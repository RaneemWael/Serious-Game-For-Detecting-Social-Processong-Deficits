using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class empathyRedResults : MonoBehaviour
{
    public Slider s;
    public Text t;

    void Start()
    {
        s.value = (float)Controller.instance.countEmpathyRedS / 20.0f;

        if (s.value < 0.5f)
        {
            t.text = "Your score indicates that there is quite a low possibility of you \nexhibiting such a trait. You are a person who behaves sensitively \nand feels for others. You also tend to understand people's \nemotions well.";
        }
        else if (s.value == 0.5f)
        {
            t.text = "Your score indicates that there is a possibility of you exhibiting \nsuch a trait. You show signs of being a person who tends to behave \ninsensitively. You probably do not know what to say to friends \nor family when they are in emotional distress as you fail to \nunderstand their emotions.";
        }
        else
        {
            t.text = "Your score indicates that there is quite a high possibility of you \nexhibiting such a trait. You show signs of being a person who \ntends to behave insensitively. You probably do not know what to say \nto friends or family when they are in emotional distress as you \nfail to understand their emotions.";
        }
    }
}
