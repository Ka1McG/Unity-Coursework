using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public float levelTime;
    public string levelRank;
    public float score;
    public bool finishedLevel;

    private void Update() 
    {
            if (finishedLevel == false)
            {
                levelTime += Time.deltaTime;
            }

            else
            {
                levelRank = "A";
            }
    }
}
