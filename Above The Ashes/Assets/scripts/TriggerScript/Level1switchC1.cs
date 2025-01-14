﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1switchC1 : MonoBehaviour
{
    public GameObject UIObject;
	  public GameObject player;
    public static bool door1open;
    public static bool door2open;
    public static bool door3open;
    public static bool door4open;

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


	void Update()
    {
      // if player is closenough with this object
		if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 1.5)
		{
			UIObject.SetActive(true);

			if (Input.GetKey("f"))
			{
        door1open = true;
				door2open = false;
        door3open = false;
        door4open = false;
			}

        }
		else{
			UIObject.SetActive(false);
		}
    }
}
