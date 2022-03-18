//playerData.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.UI;

public class playerData : MonoBehaviour
{
    //---------------------------------------------------
    //send to firebase

    public int age;
    //0=male 1=female
    public string gender;
    //0=school 1=uni
    public string education;

    public int Anhedonia;
    public int AnhedoniaS;

    public int CooperationDim;
    public int CooperationDimS;

    public int EmpathyRed;
    public int EmpathyRedS;

    public int TrustIssue;
    public int TrustIssueS;

    public int ReactIssue; 
    public int ReactIssueS;

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

    //---------------------------------------------------

    public string Stringify()
    {
        return JsonUtility.ToJson(this);
    }
    public static playerData Parse(string json)
    {
        return JsonUtility.FromJson<playerData>(json);
    }
    public IEnumerator SavePlayerData(System.Action<bool> callback = null)
    {
        using (UnityWebRequest request = new UnityWebRequest("https://webhooks.mongodb-realm.com/api/client/v2.0/app/serious-game-social-deficits-zziwh/service/SeriousGameData/incoming_webhook/webhook0", "POST"))
        {
            request.SetRequestHeader("Content-Type", "application/json");
            byte[] bodyRaw = Encoding.UTF8.GetBytes(this.Stringify());
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
                if (callback != null)
                {
                    callback.Invoke(false);
                }
            }
            else
            {
                // Debug.Log(request.downloadHandler.text);
                if (callback != null)
                {
                    callback.Invoke(request.downloadHandler.text != "{}");
                }
            }
        }
    }
    public void getData()
    {
        if (Controller.instance.age != 0)
        {
            Controller.instance.Anhedonia = (int)(((float)Controller.instance.countAnhedonia / 11.0f) * 100.0f);
            Controller.instance.AnhedoniaS = (int)(((float)Controller.instance.countAnhedoniaS / 80.0f) * 100.0f);

            Controller.instance.CooperationDim = (int)(((float)Controller.instance.countCooperationDim / 8.0f) * 100.0f);
            Controller.instance.CooperationDimS = (int)(((float)Controller.instance.countCooperationDimS / 30.0f) * 100.0f);

            Controller.instance.EmpathyRed = (int)(((float)Controller.instance.countEmpathyRed / 6.0f) * 100.0f);
            Controller.instance.EmpathyRedS = (int)(((float)Controller.instance.countEmpathyRedS / 20.0f) * 100.0f);

            Controller.instance.TrustIssue = (int)(((float)Controller.instance.countTrustIssue / 8.0f) * 100.0f);
            Controller.instance.TrustIssueS = (int)(((float)Controller.instance.countTrustIssueS / 12.0f) * 100.0f);

            Controller.instance.ReactIssue = (int)(((float)Controller.instance.countReactIssue / 6.0f) * 100.0f);
            Controller.instance.ReactIssueS = (int)(((float)Controller.instance.countReactIssueS / 12.0f) * 100.0f);

            if (Controller.instance.age == 0)
            {
                age = 15;
            }
            else if (Controller.instance.age == 1)
            {
                age = 16;
            }
            else if (Controller.instance.age == 2)
            {
                age = 17;
            }
            else if (Controller.instance.age == 3)
            {
                age = 18;
            }
            else if (Controller.instance.age == 4)
            {
                age = 19;
            }
            else if (Controller.instance.age == 5)
            {
                age = 20;
            }
            else if (Controller.instance.age == 6)
            {
                age = 21;
            }
            else if (Controller.instance.age == 7)
            {
                age = 22;
            }
            else if (Controller.instance.age == 8)
            {
                age = 23;
            }
            else if (Controller.instance.age == 9)
            {
                age = 24;
            }
            else if (Controller.instance.age == 10)
            {
                age = 25;
            }
            else if (Controller.instance.age == 11)
            {
                age = 26;
            }
            else if (Controller.instance.age == 12)
            {
                age = 27;
            }
            else if (Controller.instance.age == 13)
            {
                age = 25;
            }
            else if (Controller.instance.age == 14)
            {
                age = 26;
            }
            else if (Controller.instance.age == 15)
            {
                age = 27;
            }
            else if (Controller.instance.age == 16)
            {
                age = 28;
            }
            else if (Controller.instance.age == 17)
            {
                age = 29;
            }
            else if (Controller.instance.age == 18)
            {
                age = 30;
            }
            else if (Controller.instance.age == 19)
            {
                age = 31;
            }
            else if (Controller.instance.age == 20)
            {
                age = 32;
            }
            else if (Controller.instance.age == 21)
            {
                age = 33;
            }
            else if (Controller.instance.age == 22)
            {
                age = 34;
            }
            else if (Controller.instance.age == 23)
            {
                age = 35;
            }
            else if (Controller.instance.age == 24)
            {
                age = 36;
            }
            else if (Controller.instance.age == 25)
            {
                age = 37;
            }
            else if (Controller.instance.age == 26)
            {
                age = 38;
            }
            else if (Controller.instance.age == 27)
            {
                age = 39;
            }
            else if (Controller.instance.age == 28)
            {
                age = 40;
            }
            else if (Controller.instance.age == 29)
            {
                age = 41;
            }
            else if (Controller.instance.age == 30)
            {
                age = 42;
            }
            else if (Controller.instance.age == 31)
            {
                age = 43;
            }
            else if (Controller.instance.age == 32)
            {
                age = 44;
            }
            else if (Controller.instance.age == 33)
            {
                age = 45;
            }
            else if (Controller.instance.age == 34)
            {
                age = 46;
            }
            else if (Controller.instance.age == 35)
            {
                age = 47;
            }
            else if (Controller.instance.age == 36)
            {
                age = 48;
            }
            else if (Controller.instance.age == 37)
            {
                age = 49;
            }
            else if (Controller.instance.age == 38)
            {
                age = 50;
            }
            else if (Controller.instance.age == 39)
            {
                age = 51;
            }
            else if (Controller.instance.age == 40)
            {
                age = 52;
            }
            else if (Controller.instance.age == 41)
            {
                age = 53;
            }
            else if (Controller.instance.age == 42)
            {
                age = 54;
            }
            else if (Controller.instance.age == 43)
            {
                age = 55;
            }

            if (Controller.instance.gender == 0)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (Controller.instance.education == 0)
            {
                education = "None";
            }
            else if (Controller.instance.education == 1)
            {
                education = "School";
            }
            else
            {
                education = "University";
            }

            Anhedonia = Controller.instance.Anhedonia;
            AnhedoniaS = Controller.instance.AnhedoniaS;
            CooperationDim = Controller.instance.CooperationDim;
            CooperationDimS = Controller.instance.CooperationDimS;
            EmpathyRed = Controller.instance.EmpathyRed;
            EmpathyRedS = Controller.instance.EmpathyRedS;
            TrustIssue = Controller.instance.TrustIssue;
            TrustIssueS = Controller.instance.TrustIssueS;
            ReactIssue = Controller.instance.ReactIssue;
            ReactIssueS = Controller.instance.ReactIssueS;

            //BuriedTreasure
            MoreCoins = Controller.instance.MoreCoins;
            MoreCoins1 = Controller.instance.MoreCoins1;
            MoreCoins2 = Controller.instance.MoreCoins2;
            LeaveHint = Controller.instance.LeaveHint;

            //PGG (MagicWell)
            InvestPercentPGG = Controller.instance.InvestPercentPGG;

            //CollectApples
            Apples1 = Controller.instance.Apples1;
            Apples2 = Controller.instance.Apples2;

            //CursedForest
            BranchAnhedonia = Controller.instance.BranchAnhedonia;
            DisturbingSound = Controller.instance.DisturbingSound;

            //LockedChest
            Easy = Controller.instance.Easy;
            Medium = Controller.instance.Medium;
            Hard = Controller.instance.Hard;
            Skip = Controller.instance.Skip;
            SplitPercent = Controller.instance.SplitPercent;

            //MagicWell
            TrustOmar = Controller.instance.TrustOmar;
            Match1 = Controller.instance.Match1;
            Match2 = Controller.instance.Match2;
            ExpectedOmar = Controller.instance.ExpectedOmar;
            InvestMagicWell = Controller.instance.InvestMagicWell;
            FalseTip = Controller.instance.FalseTip;

            //WaterPipe
            Pipe1 = Controller.instance.Pipe1;
            Pipe2 = Controller.instance.Pipe2;

            //UltimatumGame
            AlertAdam = Controller.instance.AlertAdam;
            TrustAdam = Controller.instance.TrustAdam;
            Grid1 = Controller.instance.Grid1;
            Grid2 = Controller.instance.Grid2;
            ExpectedAdam = Controller.instance.ExpectedAdam;
            Offer1 = Controller.instance.Offer1;
            Offer2 = Controller.instance.Offer2;
            Offer3 = Controller.instance.Offer3;

            StartCoroutine(SavePlayerData(result => { Debug.Log(result); }));
        }
    }
}
