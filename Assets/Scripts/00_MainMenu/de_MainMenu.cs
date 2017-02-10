using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class de_MainMenu : MonoBehaviour {

    [SerializeField]
    GameObject continueButton;
    bool saveExists;

    [SerializeField]
    GameObject quitPanel;

    void Start()
    {
        continueButton.SetActive(false);
        quitPanel.SetActive(false);
        CheckForSaves();
    }

    void CheckForSaves()
    {
        if(saveExists == true)
        {
            continueButton.SetActive(true);
        }
    }


    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }


    public void openQuitPanel()
    {
        quitPanel.SetActive(true);
    }

    public void closeQuitPanel()
    {
        quitPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
