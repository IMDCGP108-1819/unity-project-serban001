using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    //When menu button is pressed, the main menu scene loads.
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}