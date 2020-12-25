using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    private Button button_pause;
    public GameObject panel = null;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        button_pause = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (gameObject.CompareTag("button_pause"))
        {
            //gameObject.SetActive(false);
            panel.SetActive(true);
        }
        else if (gameObject.CompareTag("button_play")) panel.SetActive(false);
        else SceneManager.LoadScene(scene);
    }
}
