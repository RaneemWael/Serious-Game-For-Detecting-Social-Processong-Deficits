using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject mark;

    private bool done = false;

    public void OnCollisionEnter()
    {
        if (!(done))
        {
            done = !done;
            mark.SetActive(true);
        }
    }
}
