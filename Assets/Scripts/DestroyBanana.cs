using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBanana : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Asteroid")
        {
            return;
        }
        Destroy(col.gameObject);
    }
}