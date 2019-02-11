using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Question : MonoBehaviour
{
    //JSON
    public TextAsset QuesText;
    JSONNode jNode1;
    int i, r;
    
    //Q & A
    public Text Qtext;
   
    //Timer
    public Text timer;
    float time = 35.0f,t;
    bool flag = false;

    //QuestionRandom
    private List<string> question1= new List<string>();
    private string question;
    static public int Qcount;

    
     //Use this for initialization
    void Start()
    {
        jNode1 = JSON.Parse(QuesText.text);
        QuestionText();
    }

    public void QuestionText()
    {
        r = jNode1[0].Count;
        i = 0;
        question = jNode1["Question"][i].Value;
        if (question1.Contains(question))
        {
            Q1();
        }
        else
        {
            Q2();
        }
        flag = true;
        Qcount = question1.Count;
        //print("List Count" + question1.Count);
    }

    public void Q1()
    {
        i = i + 1;
        question = jNode1["Question"][i].Value;
        if (question1.Contains(question))
        {
            Q1();
        }
        else
        {
            Q2();
        }
        Qtext.text = question;
        if (question1.Count == 16)
        {
            //Time.timeScale = 0;
            SceneManager.LoadScene("Start");
        }
    }

    public void Q2()
    {
        question = jNode1["Question"][i].Value;
        question1.Add(question);
        Qtext.text = question;
        if(question1.Count==16)
        {
            //Time.timeScale = 0;
            SceneManager.LoadScene("Start");
        }
    }

    void Timertime()
    {
        if (time > 0f)
        {
            timer.color = new Color32(219, 248, 226, 255);
            time -= Time.deltaTime;
            timer.text = time.ToString("f0");
            t = time;
        }
        if (time < 10.5f)
        {
            timer.color = Color.red;
        }
        if (time <= 0)
        {
            timer.text = time.ToString("0");
            time = 35.0f;
            QuestionText();
        }
    }

    void Update()
    {
        if (flag == true) 
        {
            Timertime();
        }
    }
}
