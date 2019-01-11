using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsButton : MonoBehaviour
{
    //When the instructions button is pressed, the instructions scene loads.
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
