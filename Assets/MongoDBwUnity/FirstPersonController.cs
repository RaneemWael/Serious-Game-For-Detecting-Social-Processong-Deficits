//playerData.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.UI;

public class FirstPersonController : MonoBehaviour
{
    /*
    void getData()
    {
        Controller.instance.Anhedonia = (int)((float)Controller.instance.countAnhedonia / 10.0f) * 100;
        Controller.instance.AnhedoniaS = (int)((float)Controller.instance.countAnhedoniaS / 80.0f) * 100;

        Controller.instance.CooperationDim = (int)((float)Controller.instance.countCooperationDim / 8.0f) * 100;
        Controller.instance.CooperationDimS = (int)((float)Controller.instance.countCooperationDimS / 30.0f) * 100;

        Controller.instance.EmpathyRed = (int)((float)Controller.instance.countEmpathyRed / 6.0f) * 100;
        Controller.instance.EmpathyRedS = (int)((float)Controller.instance.countEmpathyRedS / 20.0f) * 100;

        Controller.instance.TrustIssue = (int)((float)Controller.instance.countTrustIssue / 5.0f) * 100;
        Controller.instance.TrustIssueS = (int)((float)Controller.instance.countTrustIssueS / 12.0f) * 100;

        Controller.instance.ReactIssue = (int)((float)Controller.instance.countReactIssue / 4.0f) * 100;
        Controller.instance.ReactIssueS = (int)((float)Controller.instance.countReactIssueS / 12.0f) * 100;

        playerData.age = Controller.instance.age;
        playerData.gender = Controller.instance.gender;
        playerData.education = Controller.instance.education;
        playerData.Anhedonia = Controller.instance.Anhedonia;
        playerData.AnhedoniaS = Controller.instance.AnhedoniaS;
        playerData.CooperationDim = Controller.instance.CooperationDim;
        playerData.CooperationDimS = Controller.instance.CooperationDimS;
        playerData.EmpathyRed = Controller.instance.EmpathyRed;
        playerData.EmpathyRedS = Controller.instance.EmpathyRedS;
        playerData.TrustIssue = Controller.instance.TrustIssue;
        playerData.TrustIssueS = Controller.instance.TrustIssueS;
        playerData.ReactIssue = Controller.instance.ReactIssue;
        playerData.ReactIssueS = Controller.instance.ReactIssueS;

        StartCoroutine(playerData.SavePlayerData(result => { Debug.Log(result); }));
    }
    */
}
