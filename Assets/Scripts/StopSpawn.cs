using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSpawn : MonoBehaviour
{
    //When the player game object is destroyed, the bananas will stop spawning.
    public GameObject gameController;
    public GameObject asteroid;

    private void Awake()
    {
        gameController.SetActive(true);
    }

    private void Update()
    {
        if (asteroid == null)
        {
            gameController.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if (asteroid != null)
        {
            gameController.SetActive(true);
        }
    }
}
