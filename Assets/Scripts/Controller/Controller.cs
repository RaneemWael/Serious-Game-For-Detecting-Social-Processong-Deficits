using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;
using System.IO;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public static Controller instance;
    public GameObject player;
    public PlayerMove playerMove;
    public AudioClip btn;

    //---------------------------------------------------
    //send to firebase

    public int age;
    //0=male 1=female
    public int gender;
    //0=none 1=school 2=uni
    public int education;

    //BuriedTreasure
    public bool MoreCoins;
    public bool MoreCoins1;
    public bool MoreCoins2;
    public bool LeaveHint;
    
    //PGG (MagicWell)
    public int InvestPercentPGG = 0;

    //CollectApples
    public bool Apples1 = true;
    public bool Apples2 = true;

    //CursedForest
    public int BranchAnhedonia = 0;
    public int DisturbingSound = 0;

    //LockedChest
    public bool Easy;
    public bool Medium;
    public bool Hard;
    public bool Skip;
    public int SplitPercent = 0;

    //MagicWell
    public int TrustOmar = 0;
    public bool Match1;
    public bool Match2;
    public bool ExpectedOmar;
    public bool InvestMagicWell;
    public bool FalseTip;

    //WaterPipe
    public bool Pipe1 = true;
    public bool Pipe2 = true;

    //UltimatumGame
    public bool AlertAdam;
    public int TrustAdam = 0;
    public bool Grid1;
    public bool Grid2;
    public bool ExpectedAdam;
    public bool Offer1;
    public bool Offer2;
    public bool Offer3;

    public int Anhedonia;
    public int CooperationDim;
    public int EmpathyRed;
    public int TrustIssue;
    public int ReactIssue;

    public int AnhedoniaS;
    public int CooperationDimS;
    public int EmpathyRedS;
    public int TrustIssueS;
    public int ReactIssueS;

    //---------------------------------------------------

    public int countAnhedonia = 0;
    public int countPunishment = 0;
    public int countCooperationDim = 0;
    public int countEmpathyRed = 0;
    public int countTrustIssue = 0;
    public int countReactIssue = 0;

    //questionnaires
    public int countAnhedoniaS = 0;
    public int countCooperationDimS = 0;
    public int countEmpathyRedS = 0;
    public int countTrustIssueS = 0;
    public int countReactIssueS = 0;

    public bool finish = false;

    void Awake()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void playBtn()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(btn);
    }

    public void setAge(int i)
    {
        age = i;
    }
    public void setGender(int i)
    {
        gender = i;
    }
    public void setEducation(int i)
    {
        education = i;
    }

    public void setFinish()
    {
        finish = true;
    }

    public void pause()
    {
        playerMove.DisableMove();
        pauseSounds();
        //player.FreezeAnim();
        //unregister clicks
    }

    public void unPause()
    {
        playerMove.EnableMove();
        playSounds();
        //player.ContAnim();
        //scene.freezeAnim
        //register clicks
    }

    public void playerMoveEnable()
    {
        playerMove.EnableMove();
    }

    public void playerMoveDisable()
    {
        playerMove.DisableMove();
    }

    public void playerStartDisable()
    {
        playerMove.DisableStart();
    }

    public void playerDig()
    {
        playerMove.Dig();
    }

    public void pauseSounds()
    {
        gameObject.GetComponent<AudioSource>().Stop();
    }
    public void playSounds()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void addAnhedonia(int num)
    {
        Debug.Log("Add " + num + " to social anhedonia");
        countAnhedonia += num;
    }

    public void addPunishment(int num)
    {
        Debug.Log("Add " + num + " to altruistic punishment");
        countPunishment += num;
    }
    public void addCoopDim(int num)
    {
        Debug.Log("Add " + num + " to diminshed cooperation");
        countCooperationDim += num;
    }
    public void addEmpathyRed(int num)
    {
        Debug.Log("Add " + num + " to reduced empathy");
        countEmpathyRed += num;
    }
    public void addTrustIssue(int num)
    {
        Debug.Log("Add " + num + " to trust issues");
        countTrustIssue += num;
    }
    public void addReactIssue(int num)
    {
        Debug.Log("Add " + num + " to reaction issues");
        countReactIssue += num;
    }

    //questionnaires_add
    public void addAnhedoniaS(int num)
    {
        Debug.Log("Add " + num + " to social anhedonia survey");
        countAnhedoniaS += num;
    }
    public void addCoopDimS(int num)
    {
        Debug.Log("Add " + num + " to diminshed cooperation survey");
        countCooperationDimS += num;
    }
    public void addEmpathyRedS(int num)
    {
        Debug.Log("Add " + num + " to reduced empathy survey");
        countEmpathyRedS += num;
    }
    public void addTrustIssueS(int num)
    {
        Debug.Log("Add " + num + " to trust issues survey");
        countTrustIssueS += num;
    }
    public void addReactIssueS(int num)
    {
        Debug.Log("Add " + num + " to reaction issues survey");
        countReactIssueS += num;
    }
}

