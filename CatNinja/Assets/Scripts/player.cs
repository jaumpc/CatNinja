using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

	public Animator playerAnimator;
	public AudioSource gritinho;
	


	void Update()
	{


		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			gritinho.Play();
			playerAnimator.SetTrigger("Attack");

			

		}

	}

}