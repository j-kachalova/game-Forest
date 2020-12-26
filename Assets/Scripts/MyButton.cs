using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MyButton : MonoBehaviour
{
    public GameObject button_pause = null;
    public GameObject button_play = null;
    public GameObject panel = null;
    public GameObject imgWin = null;
    public GameObject character = null;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (gameObject.CompareTag("button_pause"))
        {
            character.SetActive(false);
            panel.SetActive(true);
        }
        else if (gameObject.CompareTag("button_play"))
        {
            character.SetActive(true);
            panel.SetActive(false);
        }
        else if (gameObject.CompareTag("exit"))
        {
            Application.Quit();
        }
        else SceneManager.LoadScene(scene);
    }
}
