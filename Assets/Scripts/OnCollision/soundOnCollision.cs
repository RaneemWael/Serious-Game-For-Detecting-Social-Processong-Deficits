using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnCollision : MonoBehaviour
{
    public void OnCollisionEnter()
    {
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<MeshCollider>().enabled = false;
        Controller.instance.playerMoveEnable();
    }
}
