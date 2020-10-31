﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroy_collider : MonoBehaviour
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

    void OnTriggerEnter(Collider collid)
    {
//      anim.SetTrigger("openlid");
//      SceneManager.LoadScene (0);
      Destroy(GetComponent<Collider>().gameObject);
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