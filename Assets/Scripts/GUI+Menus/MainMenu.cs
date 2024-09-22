using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField emailFieldInput;
    public TMP_InputField passwordFieldInput;
    //set to private after testing
    private string inputtedEmail;
    private string inputtedPassword;

    public GameObject LoginObject;
    public GameObject MainMenuObject;

    [Header("Menus")]
    public GameObject HUD;
    public GameObject EscapeMenu;
    public KeyCode escapeKey = KeyCode.G;

    private void Update() 
    {
        //Controls for the menu
        if (Input.GetKeyDown(escapeKey))
        {
            if(HUD.activeSelf)
            {
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        HUD.SetActive(false);
        EscapeMenu.SetActive(true);
    }

    public void UnPauseGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HUD.SetActive(true);
        EscapeMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void TestGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync(0);
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
