using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerTime : MonoBehaviour
{
    public Text timer;
    float time = 300.0f, t;
    bool flag = false;

    // Use this for initialization
    void Start ()
    {
        flag = true;
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
        if (time < 30.5f)
        {
            timer.color = Color.red;
        }
        if (time <= 0)
        {
            timer.text = time.ToString("0");
            time = 300.0f;
            SceneManager.LoadScene("Round 3");
            
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
