using UnityEngine;
using System.Collections;

public class GameInspector : MonoBehaviour
{
    //array where all the pipe objects in the scene are stored
    private PipeScript[] pipeObj;
    public bool levelComplete = false;

    public GameObject game;
    public GameObject finished;

    void Start()
    {
        //get all the pipeObj and are stored in array
        pipeObj = FindObjectsOfType<PipeScript>();
    }

    void Update()
    {
        CheckForLevelComplete();
        if (levelComplete)
        {
            game.SetActive(false);
            finished.SetActive(true);
        }
    }

    void CheckForLevelComplete()
    {
        for (int i = 0; i < pipeObj.Length; i++)
        {
            if (pipeObj[i].completed == false)
            {
                levelComplete = false;
                return;
            }
        }
        levelComplete = true;
    }
}