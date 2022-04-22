using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class cameraMouse : MonoBehaviour
{
    //sensitivity should be a fraction
    public float sensitivity = 0.03f; 
   /* private float xLeftBound = 1.48000002f; 
    private float xRightBound = 1.14f; 

    private float yUpperBound = 0.66f; 
    private float yLowerBound = 0.8f; 

    private int yAxis = 0; 
    private int xAxis =  0; 
    */ 

  
    void FixedUpdate() {
        float rotateHorizontal = Input.GetAxis ("Mouse X");
        float rotateVertical = Input.GetAxis ("Mouse Y");

        transform.DORotate(-transform.up * rotateHorizontal * sensitivity, (float)1); 
        transform.DORotate(-transform.right * rotateVertical * sensitivity, (float)1); 
        //Debug.Log("x: "+ rotateHorizontal); 
        //Debug.Log("y: " + rotateVertical); 
        
    }

    
  
}
