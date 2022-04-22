using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadingViews : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        StartCoroutine(fadeTime()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator fadeTime(){
        StartCoroutine(FadeTo(gameObject.GetComponent<SpriteRenderer>(), 0, 5)); 
        yield return new WaitForSeconds(10); 
        StartCoroutine(FadeTo(gameObject.GetComponent<SpriteRenderer>(), 1, 3)); 
        yield return new WaitForSeconds(10); 
        StartCoroutine(fadeTime()); 
        yield return null; 
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
