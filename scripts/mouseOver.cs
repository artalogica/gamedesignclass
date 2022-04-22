using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Yarn.Unity{
public class mouseOver : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 cursorOffset; 
    public Texture2D cursorTexture; 
    public Texture2D hoverTexture; 

    protected DialogueRunner dialogue; 

    private bool polaroidOnScreen; 

    private GameObject polaroidscreen; 
    public GameObject polaroidclicks; 

    public GameObject cm ;
    void Start()
    {
        dialogue = GameObject.Find("Dialogue").GetComponent<DialogueRunner>(); 
        cursorOffset = new Vector2(hoverTexture.width/2, hoverTexture.height/2);
        polaroidscreen = GameObject.Find("polaroidsscreen"); 

    }

    // Update is called once per frame
    void Update()
    {
        if(polaroidOnScreen){
            if(Input.GetKeyDown(KeyCode.Escape)){
                exitPolaroidView(); 
            }
        }
    }

     private void OnMouseOver() {
        
        Cursor.SetCursor(hoverTexture, cursorOffset, CursorMode.Auto); 

    }

    private void OnMouseExit() {
        Cursor.SetCursor(cursorTexture, cursorOffset, CursorMode.Auto); 
    }

    private void OnMouseDown() {
          Debug.Log(gameObject.name); 
        switch(gameObject.name){
          
            case "bunny": 
                dialogue.Stop(); 
                dialogue.StartDialogue("bunny"); 
                break; 
            
            case "phone": 
                dialogue.Stop(); 
                dialogue.StartDialogue("phone"); 
            
            break; 
            
            case "computer": 
                dialogue.Stop(); 
                dialogue.StartDialogue("inprogress"); 
            break; 


            case "polaroids": 
                //fade into polaroid 
                SpriteRenderer polaroid= polaroidscreen.GetComponent<SpriteRenderer>();
                StartCoroutine(FadeTo(polaroid, 1, 1));  
                polaroidclicks.SetActive(true); 
                scene.noClicking(); 
                polaroidOnScreen = true; 
            break; 

            case "polaroidsclickable": 
                exitPolaroidView(); 

            break; 

            case "polaroid1": 
                dialogue.Stop(); 
                dialogue.StartDialogue("polaroid1"); 

            break; 

            case "polaroid2": 
                dialogue.Stop(); 
                dialogue.StartDialogue("polaroid2"); 

            break; 

            case "polaroid3": 
                dialogue.Stop(); 
                dialogue.StartDialogue("polaroid3");
            break;  

        }

    }

    private void exitPolaroidView(){
        SpriteRenderer polaroid= polaroidscreen.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeTo(polaroid, 0, 1));  
        polaroidscreen.transform.GetChild(0).gameObject.SetActive(false); 
        scene.allClickAllowed(); 
        polaroidOnScreen = false; 

    }

    IEnumerator FadeTo(SpriteRenderer s, float aValue, float aTime)
    {
      float alpha = s.color.a;
      for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
      {
          Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,aValue,t));
          s.color = newColor;
          yield return null;
      }
  }
}
}
