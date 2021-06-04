using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("SelectScene");
    }

    public void backToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void openLink(){
        Application.OpenURL("https://kiwilimon.itch.io");
    }

    public void openCredits(){
        SceneManager.LoadScene("Creditos");
    }

    public void quitGame(){
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
