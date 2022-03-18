using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideAmount : MonoBehaviour
{
    public Slider s;
    public setController gameManager;
    public CoinCount coins;
    public Text newAmount;

    public void addPunishment()
    {
        float value = s.GetComponent<Slider>().value;
        if (value == 0.0f)
        {
            gameManager.addPunishment(5);
        }
        else if (value < 0.05f) 
        {
            gameManager.addPunishment(4);
        }
        else if (value < 0.35f)
        {
            gameManager.addPunishment(3);
        }
        else if (value < 0.65f)
        {
            gameManager.addPunishment(2);
        }
        else if (value < 0.95f)
        {
            gameManager.addPunishment(1);
        }
    }

    public void setInvestPercent()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value * 100.0f);
        gameManager.setInvestPercentPGG(val);
    }

    public void setDisturbingSound()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value * 100.0f);
        gameManager.setDisturbingSound(val);
    }

    public void setSplitPercent()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value * 100.0f);
        gameManager.setSplitPercent(val);
    }

    public void setTrustOmar()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value);
        gameManager.setTrustOmar(val);
    }

    public void setTrustAdam()
    {
        float value = s.GetComponent<Slider>().value;
        int val = (int)(value);
        gameManager.setTrustAdam(val);
    }

    public void addCoopDim()
    {
        float value = s.GetComponent<Slider>().value;
        if (value < 0.05f)
        {
            gameManager.addCoopDim(3);
        }
        else if (value < 0.25f)
        {
            gameManager.addCoopDim(2);
        }
        else if (value < 0.45f)
        {
            gameManager.addCoopDim(1);
        }
    }

    public void addEmpathyRed()
    {
        float value = s.GetComponent<Slider>().value;
        if (value < 0.05f)
        {
            gameManager.addEmpathyRed(2);
        }
        else if (value < 0.45f)
        {
            gameManager.addEmpathyRed(1);
        }
    }

    public void addTrustIssueOmar()
    {
        float value = s.GetComponent<Slider>().value;
        if (value == 10.0f)
        {
            gameManager.addTrustIssue(3);
        }
        else if (value > 7.0f)
        {
            gameManager.addTrustIssue(2);
        }
        else if (value > 5.0f)
        {
            gameManager.addTrustIssue(1);
        }
    }

    public void addTrustIssueAdam()
    {
        float value = s.GetComponent<Slider>().value;
        if (value == 0.0f)
        {
            gameManager.addTrustIssue(3);
        }
        else if (value < 3.0f)
        {
            gameManager.addTrustIssue(2);
        }
        else if (value < 5.0f)
        {
            gameManager.addTrustIssue(1);
        }
    }

    public void addReactIssueAcc()
    {
        float value = s.GetComponent<Slider>().value;
        if (value < 5.0f)
        {
            gameManager.addReactIssue(1);
        }
        else if (value < 7.0f)
        {
            gameManager.addReactIssue(2);
        }
    }

    public void addReactIssueRej()
    {
        float value = s.GetComponent<Slider>().value;
        if (value == 10.0f)
        {
            gameManager.addReactIssue(3);
        }
        else if (value > 7.0f)
        {
            gameManager.addReactIssue(2);
        }
        else if (value > 5.0f)
        {
            gameManager.addReactIssue(1);
        }
    }

    public void updateCoins()
    {
        float value = s.GetComponent<Slider>().value;
        float invest = coins.getCount() * value;
        int investInt = (int)invest;
        double add = ((coins.getCount() * (double) value) * 3.0) / 2.0;
        int addInt = (int)add;
        coins.Sub(investInt);
        coins.Add(addInt);

        newAmount.text = "You invested with " + investInt + " coins. After their trippling and halfing, you made " + addInt + " coins.";
    }

    public void updateCoinsTreasure()
    {
        float value = s.GetComponent<Slider>().value;
        float give = 30.0f * value;
        int giveInt = (int)give;
        int add = 30 - giveInt;
        coins.Add(add);

        //Text text = newAmount.GetComponent<Text>();
        newAmount.text = "You chose to give them " + giveInt + " coins. And you made " + add + " coins.";
    }
}
