using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelAfterWin : MonoBehaviour
{
      public Object ContinueScene;
    public Object GoToMenu;

   public void Continue(){
        SceneManager.LoadScene(ContinueScene.name);
    }

    public void GoBackToMenu(){
        SceneManager.LoadScene(GoToMenu.name);
    }
}
