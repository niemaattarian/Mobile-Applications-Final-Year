using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from https://www.youtube.com/watch?v=0HwZQt94uHQ
public class NextSceneObject : MonoBehaviour
{
    IEnumerator ChangeLevel ()
    {
        // fade out the game and load a new level
        float fadeTime = GameObject.Find("NextScene").GetComponent<Fading>().BeginFade(3);
        yield return new WaitForSeconds(fadeTime);
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
