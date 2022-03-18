using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeidiMove : MonoBehaviour
{
    public bool move = false;
    public bool reachEnd = false;
    public float speed;
    private int stepsBack = 1;

    // Update is called once per frame
    void Update()
    {
        if (reachEnd && move)
        {
            GetComponent<Animation>().Play("walk2");
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else if (move)
        {
            if (!(Input.anyKey))
            {
                GetComponent<Animation>().Play("idle");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                if (stepsBack > 0)
                {
                    stepsBack--;
                }
                else
                {
                    GetComponent<Animation>().Play("walk2");
                    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                stepsBack++;
                GetComponent<Animation>().Play("idle");
            }
        }
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        GetComponent<Animation>().Play("idle");
        move = false;
        reachEnd = false;
    }

    public void EnableMove()
    {
        move = true;
    }

    public void DisableMove()
    {
        move = false;
        GetComponent<Animation>().Play("idle");
    }

}
