using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ImageAnim : MonoBehaviour
{
    [SerializeField] Sprite[] imgKeyframes = new Sprite[2];
    [SerializeField] float offset = 1f;
    float currentTime = 0f;
    bool firstSprite;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Image>().sprite = imgKeyframes[0];
        firstSprite = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > offset)
        {
            GetComponent<UnityEngine.UI.Image>().sprite = firstSprite ? imgKeyframes[1] : imgKeyframes[0];
            firstSprite = firstSprite ? false : true;
            Debug.Log("Bing!");
            currentTime = 0f;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }
}
