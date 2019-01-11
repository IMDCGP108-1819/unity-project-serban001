using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //When the player game object is destroyed, the game over scene appears.
    public GameObject asteroid;

    void Update()
    {
        if (asteroid == null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
