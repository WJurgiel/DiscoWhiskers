using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CatAnim : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite[] keyframes = new Sprite[2];
    [SerializeField] float offset = 1f;
    float currentTime = 0f;
    bool firstSprite;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = keyframes[0];
        firstSprite = true;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentTime > offset) {
   
            GetComponent<SpriteRenderer>().sprite = firstSprite ? keyframes[1] : keyframes[0];

            firstSprite = firstSprite ? false : true;
            currentTime = 0f;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
        
       
    }
}
