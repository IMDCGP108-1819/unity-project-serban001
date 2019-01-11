using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Euclepula : MonoBehaviour
{

        void Update()
        {

            // Teleport the game object
            if (transform.position.x > 3.45f)
            {

                transform.position = new Vector3(-3.45f, transform.position.y, 0);

            }
            else if (transform.position.x < -3.45f)
            {
                transform.position = new Vector3(3.45f, transform.position.y, 0);
            }

        }
    }