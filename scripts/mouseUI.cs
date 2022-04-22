using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseUI : MonoBehaviour
{
    // Start is called before the first frame update

    public Texture2D cursorTexture; 
    public Texture2D hoverTexture; 
    public CursorMode cursorMode = CursorMode.Auto; 

    private Vector2 cursorOffset; 

    Ray ray;
     RaycastHit hit;

    void Start()
    {
        cursorOffset = new Vector2(cursorTexture.width/2, cursorTexture.height/2);
        
        Cursor.SetCursor(cursorTexture, cursorOffset, cursorMode); 
    }

    // Update is called once per frame
    void Update()
    {

         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if(Physics.Raycast(ray, out hit))
         {
            Cursor.SetCursor(hoverTexture, cursorOffset, cursorMode); 

         }

    }

   
}
