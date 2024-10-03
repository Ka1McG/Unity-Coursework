using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    PlayerDatabaseService playerDatabaseService;
    void Start()
    {
        playerDatabaseService = new PlayerDatabaseService();
    }

    public void OnCreatePlayerInfoButtonClick()
    {
        playerDatabaseService.CreatePlayerInfoTable();
    }

    public void onAddPlayerRanksButtonClick()
    {
        Ranks ranks = new Ranks
        {
            Email = "Mark",
            Level1 = "A"
        };
    }
}
