using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    //When retry button is pressed, the game scene is reloaded.
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
}
