using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider))]

public class ClickDrag : MonoBehaviour
{
    private Vector3 screenPoint; 
    private Vector3 offset; 
    private float _lockedYPosition;
    private float _lockedZPosition;
    private float _lockedXPosition;

    void OnMouseDown()
    {
        _lockedYPosition = gameObject.transform.position.y;
        _lockedZPosition = gameObject.transform.position.z;
        _lockedXPosition = gameObject.transform.position.x;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //Screen.showCursor = false;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint + offset);
        curPosition.y = _lockedYPosition;
        curPosition.z = _lockedZPosition;
        if (curPosition.x < _lockedXPosition - 1.5f)
        {
            curPosition.x = _lockedXPosition - 1.5f;
        }
        if (curPosition.x > _lockedXPosition + 1.5f)
        {
            curPosition.x = _lockedXPosition + 1.5f;
        }
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        //Cursor.visible = true;
    }

    public void OnCollisionEnter()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}