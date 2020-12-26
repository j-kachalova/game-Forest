using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Achievements : MonoBehaviour
{
    public int score=0;
    public string path = "";
    public string nameFile = "test.txt";
    public GameObject checkBox1 = null;
    public GameObject checkBox2 = null;
    public GameObject checkBox3 = null;
    // Start is called before the first frame update
    void Start()
    {
        OnLoad();
        if (score > 0) checkBox1.SetActive(true);
        if (score > 4) checkBox2.SetActive(true);
        if (score > 9) checkBox3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void OnLoad() // функция чтения
    {
        StreamReader sr = new StreamReader(path + "/" + nameFile);
        score = int.Parse(sr.ReadLine());
        sr.Close();
        System.Console.WriteLine(score);
    }

}
