using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, Pausebutton;

    // This stops game time when the game is paused and in the pause menu
    public void Pause(){
  
        Time.timeScale = 0;
    }

    // This Resumes the game once the resume button is pressed
    public void Resume(){

        Time.timeScale = 1;
    }
}
