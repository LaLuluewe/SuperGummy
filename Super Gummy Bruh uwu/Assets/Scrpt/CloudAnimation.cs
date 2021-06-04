using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAnimation : MonoBehaviour
{

    public Vector2 targetPosition = new Vector2(0,0);
    public float speed = 1;

    public Vector2 startPosition = new Vector2(0,0);    
    // Update is called once per frame
    void Update()
    {   
        if(transform.position.x >= targetPosition.x){
            transform.position = startPosition;
        }else{
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        }
    }
}
