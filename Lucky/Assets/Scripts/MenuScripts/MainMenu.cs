using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

	public void PlayGame()
	{
		// Key Pressing Sound
		KeyPressScript.PlaySound ("KeyPress");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);		
	}

	public void Volume(){
		// Key Pressing Sound
		KeyPressScript.PlaySound ("KeyPress");
	}
	
	public void QuitGame()
	{
		// Key Pressing Sound
		KeyPressScript.PlaySound ("KeyPress");
		Debug.Log("QUIT!!!");
		Application.Quit();
	}
   
}
