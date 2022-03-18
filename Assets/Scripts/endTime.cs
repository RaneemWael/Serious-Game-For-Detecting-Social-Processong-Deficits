using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTime : MonoBehaviour
{
    void Start()
    {
        Invoke("end", 1800.0f);
    }
    void end()
    {
        Controller.instance.pauseSounds();
        SceneManager.LoadScene("Timeout");
    }
}
