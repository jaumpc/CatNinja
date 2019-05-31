using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxLife : MonoBehaviour {


	public LevelChanger LevelChanger;
	public Animator hitpoint;
	public Animator boxAnimator;
	public AudioSource som;

	int boxDamage = 0;

	private void playSound()
	{
		som.Play();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		boxAnimator.SetTrigger("DamageBox");
		hitpoint.SetTrigger("DamageBox");
		boxDamage++;


		if (boxDamage == 3)
		{
			boxAnimator.SetTrigger("OverBox");
			LevelChanger.FadeNextScene();
			
		}
	}
}
