using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setPlayerInfo : MonoBehaviour
{
    public Dropdown age;
    public Dropdown gender;
    public Dropdown education;

    public void set()
    {
        Controller.instance.setAge(age.value);
        Controller.instance.setGender(gender.value);
        Controller.instance.setEducation(education.value);
    }

}
