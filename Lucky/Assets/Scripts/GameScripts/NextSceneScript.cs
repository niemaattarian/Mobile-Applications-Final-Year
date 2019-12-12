using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour
{
    private int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
        // Loads scene by order of build
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Loads scene when player walks into collider
        SceneManager.LoadScene(nextSceneLoad);
    }
}