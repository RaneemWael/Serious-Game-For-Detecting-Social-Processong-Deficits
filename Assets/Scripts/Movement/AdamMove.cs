using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamMove : MonoBehaviour
{
    public bool move;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            GetComponent<Animator>().Play("Anim_Walk");
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        move = false;
    }

    public void EnableMove()
    {
        move = true;
    }
}
