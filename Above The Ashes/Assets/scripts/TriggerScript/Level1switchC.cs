﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1switchC : MonoBehaviour
{
    public GameObject UIObject;
	public GameObject Door1;
    public GameObject Door2;
	public GameObject Door3;
	public GameObject Door4;
    private bool isOpen = false;

    void Start()
    {
        // at first the text should not display
        UIObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // when player is near the chest
        if (other.tag == "Player")
        {
            // show the text
            UIObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // when player leaves the trigger, text disappear
        UIObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (isOpen)
        {
            return;
        }
        else
        {
            Door1.SetActive(false);
			Door2.SetActive(true);
			Door3.SetActive(true);
			Door4.SetActive(true);
            isOpen = false;
        }
    }
}