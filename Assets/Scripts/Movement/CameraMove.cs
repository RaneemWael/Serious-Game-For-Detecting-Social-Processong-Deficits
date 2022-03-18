using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public bool start = false;
    public bool move;
    public float speed;
    public float clampLeft;
    public float clampRight;

    void Update()
    {
        if (start)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                start = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                start = false;
            }
        }
        else if (move)
        {
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < clampRight)
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > clampLeft)
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
        }
    }
}
