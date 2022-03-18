using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigButton : MonoBehaviour
{
    public int count = 0;
    public int trial = 1;
    public GameObject btn;
    public GameObject afterDig;
    public CoinCount coinCountBar;
    public GameObject moreCoins;
    public GameObject moreCoins1;
    public GameObject moreCoins2;
    public GameObject finish;

    public void OnClickEnter()
    {
        count++;
        if (count == 3)
        {
            Remove();
        }
    }

    void Remove()
    {
        btn.SetActive(false);
        coinCountBar.Add(20);
        afterDig.SetActive(true);
        if (trial == 4)
        {
            finish.SetActive(true);
        }
        else if (trial == 3)
        {
            moreCoins2.SetActive(true);
        }
        else if (trial == 2)
        {
            moreCoins1.SetActive(true);
        }
        else if (trial == 1)
        {
            moreCoins.SetActive(true);
        }
    }

    public void Restart()
    {
        count = 0;
        trial++;
    }
}
