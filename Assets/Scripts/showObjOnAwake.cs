using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObjOnAwake : MonoBehaviour
{
    public GameObject o;

    void Awake()
    {
        o.SetActive(true);
    }
}
