using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool start = true;
    public bool move;
    public float speed;
    public float clampLeft;
    public float clampRight;
    public CameraMove cam;

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (!(Input.anyKey))
            {
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Rest1");
                }
                else
                {
                    GetComponent<Animation>().Play("idle");
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < -21)
            {
                cam.start = true;
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Walk");
                }
                else
                {
                    GetComponent<Animation>().Play("walk2");
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > clampLeft)
            {
                cam.start = true;
                transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Walk_Back");
                }
                else
                {
                    GetComponent<Animation>().Play("walk1");
                }
            }
        }
        else if (move)
        {
            if (!(Input.anyKey))
            {
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Rest1");
                }
                else
                {
                    GetComponent<Animation>().Play("idle");
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < clampRight)
            {
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Walk");
                }
                else
                {
                    GetComponent<Animation>().Play("walk2");
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > clampLeft)
            {
                transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
                if (Controller.instance.gender == 0)
                {
                    GetComponent<Animator>().Play("Anim_Walk_Back");
                }
                else
                {
                    GetComponent<Animation>().Play("walk1");
                }
            }
        }
        else
        {
            if (Controller.instance.gender == 0)
            {
                GetComponent<Animator>().Play("Anim_Rest1");
            }
            else
            {
                GetComponent<Animation>().Play("idle");
            }
        }
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        move = false;
        cam.move = false;
    }

    public void active()
    {
        gameObject.SetActive(true);
    }

    public void DisableMove()
    {
        move = false;
        cam.move = false;
    }

    public void EnableMove()
    {
        move = true;
        cam.move = true;
    }

    public void DisableStart()
    {
        start = false;
        cam.start = false;
    }

    public void Dig()
    {
        /*
        if (Controller.instance.gender == 0)
        {
            GetComponent<Animator>().Play("Anim_Take");
        }
        else
        {
            GetComponent<Animation>().Play("crouch");
        }
        */
    }

}
