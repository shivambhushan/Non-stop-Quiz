using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimationChange : MonoBehaviour
{
    
    public Text timer;
    public Animator Anim1;
    public Animator Anim2;
    public Animator Anim3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AnimPlay1();
    }

    public void AnimPlay1()
    {
        if (timer.text == "0")
        {
            Anim1.Play("Bam", 0, 0);
            Anim2.Play("Bam", 0, 0);
            Anim3.Play("ScaleChange", 0, 0);
        }
    }
}
   





  

