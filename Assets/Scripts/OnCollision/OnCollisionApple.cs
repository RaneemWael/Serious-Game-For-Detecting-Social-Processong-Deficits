using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionApple : MonoBehaviour
{
    public GameObject appNext;

    public void OnCollisionEnter()
    {
        gameObject.SetActive(false);
        appNext.SetActive(true);
    }
}
