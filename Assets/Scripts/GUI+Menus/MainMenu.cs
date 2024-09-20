using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField emailFieldInput;
    public TMP_InputField passwordFieldInput;
    //set to private after testing
    private string inputtedEmail;
    private string inputtedPassword;

    public GameObject LoginObject;
    public GameObject MainMenuObject;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StoreInputs()
    {
        inputtedEmail = emailFieldInput.text;
        inputtedPassword = passwordFieldInput.text;

        Debug.Log(inputtedEmail);
        Debug.Log(inputtedPassword);
    }

    public void LogInCheck()
    {
        StoreInputs();
        if(inputtedEmail == "gmac283")
        {
            Debug.Log("email's worked");
            SuccessfulLoginToMenu();
        }
        else
        {
            {
                Debug.Log("Email's not worked");
            }
        }
    }

    public void SuccessfulLoginToMenu()
    {
        LoginObject.SetActive(false);
        MainMenuObject.SetActive(true);
    }
}
