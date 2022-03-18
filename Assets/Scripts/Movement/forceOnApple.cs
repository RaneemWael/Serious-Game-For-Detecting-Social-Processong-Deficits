using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceOnApple : MonoBehaviour
{
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, -0.2f, 0);
    }
}
