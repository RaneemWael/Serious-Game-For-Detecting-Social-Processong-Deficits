using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHeidiToTreasure : MonoBehaviour
{
    public HeidiMove mark;

    public void OnCollisionEnter()
    {
        mark.reachEnd = true;
    }
}
