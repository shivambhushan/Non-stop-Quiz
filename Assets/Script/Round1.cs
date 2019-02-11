using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Round1 : MonoBehaviour
{
    public Button button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Pressed()
    {
        if(button.interactable==true)
        {
            SceneManager.LoadScene("Round 1");
        }
    }
}
