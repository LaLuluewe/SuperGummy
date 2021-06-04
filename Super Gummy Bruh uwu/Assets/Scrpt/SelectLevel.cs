using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectLevel : MonoBehaviour
{
    public Object Level1Scene;
   public void Level1(){
        SceneManager.LoadScene(Level1Scene.name);
    }

    //public void Level2(){
        //Poner los parametros correspondientes al nivel 2
         //SceneManager.LoadScene(Level2Scene.name);

    //}

   // public void Level3(){
    //Poner los parametros correspondientes al nivel 3
     // SceneManager.LoadScene(Level3Scene.name);

    //}

}
