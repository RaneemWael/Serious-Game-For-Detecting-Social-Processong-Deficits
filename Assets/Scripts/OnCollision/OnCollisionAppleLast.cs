using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionAppleLast : MonoBehaviour
{
    public GameObject finish;

    public void OnCollisionEnter()
    {
        gameObject.SetActive(false);
        finish.SetActive(true);
    }
}
