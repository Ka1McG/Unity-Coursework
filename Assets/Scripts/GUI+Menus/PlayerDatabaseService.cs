using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDatabaseService{
    DB dB;
    StatManager statManager;
    public PlayerDatabaseService()
    {
        dB = new DB();
    }

    public void CreatePlayerInfoTable(){
		dB.GetConnection().DropTable<PlayerDatabase> ();
		dB.GetConnection().CreateTable<PlayerDatabase> ();
    }

    public PlayerDatabase CreatePlayerInPlayerDatabase(){
		var ppd = new PlayerDatabase{
				Email = "Markk",
				PlayTime = 0,
				AverageRank = 0
		};
		dB.GetConnection().Insert (ppd);
		return ppd;
	}

}
