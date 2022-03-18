using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countBranch : MonoBehaviour
{
    public int count = 1;

    public GameObject branch2;
    public GameObject branch3;
    public GameObject branch4;
    public GameObject branch5;
    public GameObject branch6;
    public GameObject branch7;
    public GameObject branch8;
    public GameObject branch9;
    public GameObject branch10;

    public GameObject finish;

    public void nextBranch()
    {
        if (count == 2)
        {
            branch2.SetActive(true);
        }
        else if (count == 3)
        {
            branch3.SetActive(true);
        }
        else if (count == 4)
        {
            branch4.SetActive(true);
        }
        else if (count == 5)
        {
            branch5.SetActive(true);
        }
        else if (count == 6)
        {
            branch6.SetActive(true);
        }
        else if (count == 7)
        {
            branch7.SetActive(true);
        }
        else if (count == 8)
        {
            branch8.SetActive(true);
        }
        else if (count == 9)
        {
            branch9.SetActive(true);
        }
        else if (count == 10)
        {
            branch10.SetActive(true);
        }
        else
        {
            finish.SetActive(true);
        }
    }

    public void add()
    {
        count++;
    }
}
