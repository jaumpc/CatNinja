﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuriken : MonoBehaviour {


    public float speed = 20f;
    public Rigidbody2D rb;


	void Start () {

        rb.velocity = transform.right * speed;
		

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.tag == "muro")
		{
			Destroy(gameObject);
		}

		else if (collision.gameObject.tag == "caixa")
		{
			Destroy(gameObject);
		}



	}


}
