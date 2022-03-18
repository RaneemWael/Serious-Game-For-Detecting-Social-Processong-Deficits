using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setController : MonoBehaviour
{
    public int notSureShort = 0;
    public int notSureLong = 0;

    public void showObj (GameObject x)
    {
        Instantiate(x);
    }

    public void remove(GameObject x)
    {
        Destroy(x);
    }

    public void nextScene()
    {
        Controller.instance.nextScene();
    }

    public void playBtn()
    {
        Controller.instance.playBtn();
    }

    public void setFinish()
    {
        Controller.instance.setFinish();
    }

    public void pause()
    {
        Controller.instance.pause();
    }

    public void unPause()
    {
        Controller.instance.unPause();
    }

    public void playerMoveEnable()
    {
        Controller.instance.playerMoveEnable();
    }

    public void playerMoveDisable()
    {
        Controller.instance.playerMoveDisable();
    }

    public void playerStartDisable()
    {
        Controller.instance.playerStartDisable();
    }

    public void playerDig()
    {
        Controller.instance.playerDig();
    }

    public void pauseSounds()
    {
        Controller.instance.pauseSounds();
    }
    public void playSounds()
    {
        Controller.instance.playSounds();
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void setMoreCoins()
    {
        Controller.instance.MoreCoins = true;
    }
    public void setMoreCoins1()
    {
        Controller.instance.MoreCoins1 = true;
    }
    public void setMoreCoins2()
    {
        Controller.instance.MoreCoins2 = true;
    }
    public void setLeaveHint()
    {
        Controller.instance.LeaveHint = true;
    }

    public void setInvestPercentPGG(int x)
    {
        Controller.instance.InvestPercentPGG = x;
    }

    public void setApples1()
    {
        Controller.instance.Apples1 = false;
    }
    public void setApples2()
    {
        Controller.instance.Apples2 = false;
    }

    public void setBranchAnhedonia(int x)
    {
        Controller.instance.BranchAnhedonia = x;
    }
    public void setDisturbingSound(int x)
    {
        Controller.instance.DisturbingSound = x;
    }

    public void setEasy()
    {
        Controller.instance.Easy = true;
    }
    public void setMedium()
    {
        Controller.instance.Medium = true;
    }
    public void setHard()
    {
        Controller.instance.Hard = true;
    }
    public void setSkip()
    {
        Controller.instance.Skip = true;
    }
    public void setSplitPercent(int x)
    {
        Controller.instance.SplitPercent = x;
    }

    public void setTrustOmar(int x)
    {
        Controller.instance.TrustOmar = x;
    }
    public void setMatch1()
    {
        Controller.instance.Match1 = true;
    }
    public void setMatch2()
    {
        Controller.instance.Match2 = true;
    }
    public void setExpectedOmar()
    {
        Controller.instance.ExpectedOmar = true;
    }
    public void setInvestMagicWell()
    {
        Controller.instance.InvestMagicWell = true;
    }
    public void setFalseTip()
    {
        Controller.instance.FalseTip = true;
    }

    public void setPipe1()
    {
        Controller.instance.Pipe1 = false;
    }
    public void setPipe2()
    {
        Controller.instance.Pipe2 = false;
    }

    public void setAlertAdam()
    {
        Controller.instance.AlertAdam = true;
    }
    public void setTrustAdam(int x)
    {
        Controller.instance.TrustAdam = x;
    }
    public void setGrid1()
    {
        Controller.instance.Grid1 = true;
    }
    public void setGrid2()
    {
        Controller.instance.Grid2 = true;
    }
    public void setExpectedAdam()
    {
        Controller.instance.ExpectedAdam = true;
    }
    public void setOffer1()
    {
        Controller.instance.Offer1 = true;
    }
    public void setOffer2()
    {
        Controller.instance.Offer2 = true;
    }
    public void setOffer3()
    {
        Controller.instance.Offer3 = true;
    }

    public void addAnhedonia(int num)
    {
        Controller.instance.addAnhedonia(num);
    }

    public void addAnhedoniaRewardBias()
    {
        if (notSureShort - notSureLong > 0)
        {
            Controller.instance.addAnhedonia(notSureShort - notSureLong);
        }

        setBranchAnhedonia(notSureShort - notSureLong);
    }

    public void addPunishment(int num)
    {
        Controller.instance.addPunishment(num);
    }
    public void addCoopDim(int num)
    {
        Controller.instance.addCoopDim(num);
    }
    public void addEmpathyRed(int num)
    {
        Controller.instance.addEmpathyRed(num);
    }
    public void addTrustIssue(int num)
    {
        Controller.instance.addTrustIssue(num);
    }
    public void addReactIssue(int num)
    {
        Controller.instance.addReactIssue(num);
    }
}
