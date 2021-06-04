using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour
{
    Animator anim;
    //SpriteRenderer sprite;
    private void Start(){
        anim = GetComponent<Animator>();
        //sprite = GetComponent<SpriteRenderer>();

    }

    private void Update() {
        anim.SetBool("IsRunning", true);
    }
    
   
    
  
    


   
}
