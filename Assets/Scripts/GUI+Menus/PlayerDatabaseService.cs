using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDatabaseService{
    DB dB;

    public PlayerDatabaseService()
    {
        dB = new DB();
    }

    public void CreatePlayerInfoTable(){
		dB.GetConnection().DropTable<PlayerDatabase> ();
		dB.GetConnection().CreateTable<PlayerDatabase> ();
    }
}
