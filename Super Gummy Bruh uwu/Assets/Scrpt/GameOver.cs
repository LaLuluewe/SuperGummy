using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Object QuitGame;
    public Object RestartLevels;

    public void BackMenu(){
        SceneManager.LoadScene(QuitGame.name);
    }

    public void RestartLevel(){
        SceneManager.LoadScene(RestartLevels.name);
    }
}   
