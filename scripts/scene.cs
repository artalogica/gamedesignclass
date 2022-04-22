using System.Collections;
using System.Collections.Generic;
using System; 
using UnityEngine;
using DG.Tweening; 


namespace Yarn.Unity{
public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        noClicking(); 
        moveWithMouse.moveEnabled = false; 
    }

    [YarnCommand("allowMovement")]
    public static void allowMovement(){
        moveWithMouse.moveEnabled = true; 
    }

    public static void noClicking(){ //tunrs off al box coliders
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("collider")){
            try{

                    Collider2D c = g.GetComponent<Collider2D>(); 
                    c.enabled = false; 
               
            } catch (Exception e){
                Debug.Log(e); 
            }

        }
    }

    [YarnCommand("clickAllowed")]    
    public static void allClickAllowed(){
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("collider")){
                Collider2D c = g.GetComponent<Collider2D>(); 
                c.enabled = true;  

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void computerView(){
        
    }

        //fades sprites 

}
}
