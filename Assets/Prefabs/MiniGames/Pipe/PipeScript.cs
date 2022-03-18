using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PipeScript : MonoBehaviour
{
    [Header("Used to check the piece rotation")]
    [SerializeField]
    private Vector3 currentAngle;    //this the angle the piece is currently in the scene
    [SerializeField]
    private Vector3 originalAngle;    //this the angle the piece need to complete level
    private Vector3 targetAngle;

    public int rotationDirection = -1; // -1 for clockwise & 1 for anti-clockwise
    public int rotationStep = 10; // should be less than 90
    private bool rotating = false;
    
    public bool completed = false;  

    private Vector3 currentRotation;
    private Vector3 targetRotation;
    
    void Awake()
    {
        completed = false;
    }


    void Start()
    {
        //currentAngle = gameObject.transform.eulerAngles;
    }

    void Update()
    {
        currentAngle = gameObject.transform.eulerAngles;

        if (gameObject.transform.rotation.z == 0.0f)
        {
            completed = true;
        }
        else
        {
            completed = false;
        }
    }

    public void RotateObj()
    {
        currentAngle = gameObject.transform.eulerAngles;
        targetAngle.z = currentAngle.z + (90 * rotationDirection);
        transform.DOLocalRotate(targetAngle, 0.2f);
    }
    
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !rotating)
        {
            rotating = true;
            gameObject.GetComponent<AudioSource>().Play();
            RotateObj();
            StartCoroutine(RotatingTrue());
        }
    }

    //for limiting the number of taps per second
    IEnumerator RotatingTrue()
    {
        yield return new WaitForSeconds(0.25f);
        rotating = false;
    }
}