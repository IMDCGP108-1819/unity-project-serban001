using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //When the PlayGame button is pressed, the main game scene loads and the game starts.
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
