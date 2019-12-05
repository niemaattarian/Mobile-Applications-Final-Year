using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

	public void PlayGame()
	{
		KeyPressScript.PlaySound ("KeyPress");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);		
	}

	public void Volume(){
		KeyPressScript.PlaySound ("KeyPress");
	}
	
	public void QuitGame()
	{
		KeyPressScript.PlaySound ("KeyPress");
		Debug.Log("QUIT!!!");
		Application.Quit();
	}
   
}
