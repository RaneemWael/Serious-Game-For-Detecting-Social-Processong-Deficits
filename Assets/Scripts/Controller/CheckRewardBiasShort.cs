using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckRewardBiasShort : MonoBehaviour
{
    public Toggle t;
    public setController cont;

    public void check()
    {
        if (!(t.isOn))
        {
            cont.notSureShort += 1;
        }
    }
}
