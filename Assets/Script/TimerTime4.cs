using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerTime4 : MonoBehaviour
{
    public Text timer;
    float time = 300.0f, t;
    bool flag = false;
    public Text thnx;

    // Use this for initialization
    void Start ()
    {
        thnx.enabled = false;
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
            //time = 300.0f;
            timer.enabled = false;
            thnx.enabled = true;
            Time.timeScale = 0.1f;

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
