﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Collider_restart : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

            SceneManager.LoadScene(0);
    }

    void OnTriggerExit(Collider other)
    {
      anim.enabled = true;
    }

    void pauseAnimationEvent()
    {
      anim.enabled = false;
    }

}
