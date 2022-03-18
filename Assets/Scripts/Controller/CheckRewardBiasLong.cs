using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckRewardBiasLong : MonoBehaviour
{
    public Toggle t;
    public setController cont;

    public void check()
    {
        if (!(t.isOn))
        {
            cont.notSureLong += 1;
        }
    }
}
