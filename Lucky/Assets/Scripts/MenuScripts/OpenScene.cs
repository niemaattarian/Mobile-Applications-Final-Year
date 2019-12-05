using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScene : MonoBehaviour
{
    public AudioClip sfxButton;

    private bool oneshotSfx;

    // Update once per frame
    void Update()
    {
        // If any key is pressed, jump to gameplay scene
        if(Input.anyKeyDown)
        {
            if(!oneshotSfx)
            {
                
                //AudioSource.PlayClipAtPoint(sfxButton, Vector3.zero);
                Invoke("LoadScene", 0.5f);
                oneshotSfx = true;
            }
        }
    }

    void LoadScene()
    {
        //Load gameplay scene
        Application.LoadLevel("Scenes/MenuScenes/MainMenu");
    }
}
