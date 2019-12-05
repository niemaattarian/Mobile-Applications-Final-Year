using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressScript : MonoBehaviour
{
    public static AudioClip keyPressSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        keyPressSound = Resources.Load<AudioClip> ("KeyPress");
        
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch(clip) {
            case "KeyPress":
                audioSrc.PlayOneShot (keyPressSound);
                break;
        }
    }
}
