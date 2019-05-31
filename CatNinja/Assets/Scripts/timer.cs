using UnityEngine;

public class timer : MonoBehaviour {

	public LevelChanger LevelChanger;
	[SerializeField] private float timeLeft;

	public float TimeLeft
	{
		get
		{
			return timeLeft;
		}

		set
		{
			timeLeft = value;
		}
	}

	public void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			LevelChanger.FadeNextScene();
		}

	}
}
