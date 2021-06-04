using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : Enemy
{
    public Transform[] patrolPoint;
    public float speed;
    int currentPointIndex;


    float waitTime;
    public float startWaitTime;

    private void Start(){
        transform.rotation = patrolPoint[0].rotation;
        transform.position = patrolPoint[0].position;
        waitTime = startWaitTime; 

    }

    private void Update() {

        this.transform.position = Vector2.MoveTowards(transform.position, patrolPoint[currentPointIndex].position, speed * Time.deltaTime);
        if(transform.position == patrolPoint[currentPointIndex].position){
            if(waitTime <= 0){
                if(currentPointIndex + 1 < patrolPoint.Length){
                    currentPointIndex++;
                }else
                {
                    currentPointIndex = 0;
                }
                waitTime = startWaitTime;
                }
            else{
                waitTime -= Time.deltaTime;
            }
            

            
       
        }
    }
  
}