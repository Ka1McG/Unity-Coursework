using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [Header("Difficulty")]
    public int difficulty = 2;

    public void SetEasyDifficulty()
    {
       difficulty = 1;
    }
    public void SetMediumDifficulty()
    {
       difficulty = 2;
    }
    public void SetHardDifficulty()
    {
       difficulty = 3;
    }
    public void SetHellDifficulty()
    {
       difficulty = 4;
    }
}
