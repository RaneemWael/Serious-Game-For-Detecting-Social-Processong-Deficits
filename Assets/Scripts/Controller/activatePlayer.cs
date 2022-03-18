using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePlayer : MonoBehaviour
{
    public GameObject playerMale;
    public PlayerMove playerMoveMale;
    public GameObject playerFemale;
    public PlayerMove playerMoveFemale;

    public void Awake()
    {
        if (Controller.instance.gender == 0)
        {
            Controller.instance.player = playerMale;
            Controller.instance.playerMove = playerMoveMale;
            playerMale.SetActive(true);
        }
        else
        {
            Controller.instance.player = playerFemale;
            Controller.instance.playerMove = playerMoveFemale;
            playerFemale.SetActive(true);
        }
    }
}
