using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;

	public void FadeNextScene()
	{
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete()
	{
		int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		if (CurrentSceneIndex == 3)
		{
			SceneManager.LoadScene(0);
		}
		else
		{
			SceneManager.LoadScene(CurrentSceneIndex + 1);
		}
	}


	public void Exitgame()
	{
		Application.Quit();
	}
}
