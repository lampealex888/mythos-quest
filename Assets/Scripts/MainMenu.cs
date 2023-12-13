using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnContinueGameButton()
    {
        // todo
    }

    public void OnNewGameButton()
    {
        SceneManager.LoadScene(2);
    }
    
    public void OnLoadGameButton()
    {
        // todo
    }
    public void OnMultiplayerButton()
    {
        // todo
    }

    public void OnOptionsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnCreditsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
