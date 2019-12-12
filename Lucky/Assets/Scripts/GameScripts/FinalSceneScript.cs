using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneScript : MonoBehaviour
{

    private int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         nextSceneLoad = SceneManager.GetActiveScene().buildIndex - 3;
        SceneManager.LoadScene(nextSceneLoad);
    }
}
