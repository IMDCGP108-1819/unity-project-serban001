using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    //When the credits button is pressed the credits scene will load.
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
