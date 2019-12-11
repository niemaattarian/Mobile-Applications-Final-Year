using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from this video https://www.youtube.com/watch?v=0HwZQt94uHQ
public class Fading : MonoBehaviour
{
    public Texture2D fadeOutTexture;        // the texture that will overlay the screen
    public float fadeSpeed = 0.8f;          // the fading speed
    private int drawDepth = -1000;          // the textures order in the draw hierarchy
    private float alpha = 1.0f;
    private int fadeDir = -1;               // the direction to fade: in = -1 or out = 1

   void OnGUI () {
       // fade out/in the alpha value using a directon, a speed and Time.deltatime to convert the operation to seconds
       alpha += fadeDir * fadeSpeed * Time.deltaTime;
       // force (clamp) the number between 0 and 1 because GUI.color uses alpha values between 0 and 1
       alpha = Mathf.Clamp01(alpha);

        // set color of GUI 
        GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);           // set alpha value
        GUI.depth = drawDepth;                                                          // make the black texture render on top
        GUI.DrawTexture ( new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture); // draw the texture to fit the entire screen area                                          
   }

   // sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1
   public float BeginFade (int direction)
   {
       fadeDir = direction;
       return (fadeSpeed);      // return the fadeSpeed var to time the app load level
   }

   // OnLevelWasLoaded is called when a level is loaded
   void OnLevelWasLoaded(){
        // alpha = 1;
        BeginFade(-1);
   }
}
