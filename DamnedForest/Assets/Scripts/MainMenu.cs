using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameLevel;
    public GameObject optionsScreen;
    public GameObject controlsScreen;

    void Start()
    {
        UnlockMouse();
    }

    void Update()
    {
        
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(gameLevel);
    }

    public void OpenControls()
    {
        controlsScreen.SetActive(true);
    }

    public void CloseControls()
    {
        controlsScreen.SetActive(false);
    }

    public void OpenOptions() 
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions() 
    {
        optionsScreen.SetActive(false);
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
    
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
