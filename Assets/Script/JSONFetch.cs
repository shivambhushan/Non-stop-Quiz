using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class JSONFetch : MonoBehaviour
{
    public TextAsset QuesText;
    JSONNode jNode1;
    private int r, i;
    string question, answer;

    // Use this for initialization
    void Start ()
    {
        jNode1 = JSON.Parse(QuesText.text);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void JSONFetch1()
    {
        r = jNode1[0].Count;
        i = Random.Range(0, r);
        question = jNode1["Question"][i].Value;
        answer = jNode1["Answer"][i].Value;
    }
}
