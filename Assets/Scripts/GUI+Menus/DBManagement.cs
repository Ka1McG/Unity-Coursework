using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal.Builders;
using Unity.VisualScripting;
using UnityEngine;

public class DBManagement : MonoBehaviour
{
    //pdsp stands for "PlayerDatabaseService(Player)"
    private PlayerDatabaseService pdsp = new PlayerDatabaseService("PlayerDatabase.db");
    public void AddPlayerToPlayerDatabase()
    {
        pdsp.CreatePlayerInPlayerDatabase();
    }

//    public void UpdatePassword()
//    {
//        PlayerDatabase playerDatabase = new PlayerDatabase
//        {
//            PlayerID = 2,
//            Email = "Markk",
//            Password = "TestPassword",
//            Username = "Jeff",
//            PlayTime = 0,
//            AverageRank = 0
//        };
//        int val = pdsp.UpdatePlayerPassword(playerDatabase);
//    }


}
