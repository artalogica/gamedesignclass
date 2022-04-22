using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Yarn.Unity{
public class continueText : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject text; 
    private LineView line; 
    private bool textOngoing; 


    public void textIsOngoing(){
        
        textOngoing = true; 
    }

    public void textFinished(){
        textOngoing = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (textOngoing){
            if(Input.anyKeyDown && Input.GetMouseButtonDown(0)){
                line = text.GetComponent<LineView>(); 
                line.OnContinueClicked(); 
            }
        }
    }
}

}

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchflipper : MonoBehaviour
{
    public GameObject currentlyOn; 
    public GameObject currentlyOff; 
    // Start is called before the first frame update
   private void OnMouseDown() {
       GameObject temp = currentlyOn; 
       currentlyOn = currentlyOff; 
       currentlyOn.GetComponent<SpriteRenderer>().color = new Color (255,255,255,255); 
       currentlyOff = temp; 
       currentlyOff.GetComponent<SpriteRenderer>().color = new Color (255,255,255,255); 

   }
}



*/