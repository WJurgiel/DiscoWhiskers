using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public GameObject gm_panel;
    public float interval = 1f;
    float current_time = 0f;
    float alpha = 255;
    UnityEngine.UI.Image img;
    private void Start()
    {
        // gm_panel.GetComponent<UnityEngine.UI.Image>().color = new Color(0,0,0, alpha);
        /*img = gm_panel.GetComponent<UnityEngine.UI.Image>();*/
        StartCoroutine(deactivatePanel());
    }

    private void Update()
    {
        //if (current_time > interval && alpha > 0) 
        //{
        //    alpha--;
        //    img.color = new Color(0, 0, 0, alpha);
        //    current_time = 0;
        //    Debug.Log(img.color);
        //}
        //else
        //{
        //    current_time += Time.deltaTime;
        //}

  
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Debug.Log("Sosik");
        gm_panel.SetActive(true);
        StartCoroutine(dissolve());
        Application.Quit();
    }
    
    IEnumerator dissolve()
    {
        gm_panel.GetComponent<Animator>().SetBool("isQuiting", true);
        yield return new WaitForSeconds(1.5f);
    }

    IEnumerator deactivatePanel()
    {
        yield return new WaitForSeconds(1.2f);
        gm_panel.SetActive(false);
    }
    
   
}
