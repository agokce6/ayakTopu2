using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScripti : MonoBehaviour {

	private bool enable;
	public void Menu (int basla) {
		
	    if (basla == 1) {
            SceneManager.LoadScene(2);
			SceneManager.sceneLoaded += OnSceneLoaded;
		}
		if (basla == 2) {
            Debug.Log("Çık");
			Application.Quit();
		}
		if (basla == 3) {
            SceneManager.LoadScene(1);
	   }
		if (basla == 4)
		{
			enable = !enable;
		}
		if(enable)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
			Time.fixedDeltaTime = 0.02f*Time.timeScale;
		}
	}
	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Time.timeScale = 1;
	}
}
