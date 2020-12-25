using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharText : MonoBehaviour
{
    [SerializeField] CharacterControllerScript characterController = null;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        getText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getText()
    {
        myText.text = "ЖЁЛУДИ " + characterController.score + "/10";
        //if (characterController.score == 10) ;
    }
}
