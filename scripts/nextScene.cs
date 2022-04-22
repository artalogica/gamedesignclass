using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadScene(){
        SceneManager.LoadScene(1);
    }

    public void backToMenu(){
        SceneManager.LoadScene(0); 
    }
}
