
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour

{
    public Camera cam;
    public GameObject banana;
    public float fallSpeed = 40.0f;
    public Text timerText;
    public float score;
    public GameObject Asteroid;

    void Start()
    {
        StartCoroutine(Spawn());
        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(2f);
            while (true)
            { 
                ;
                Vector3 spawnPosition = new Vector3(Random.Range(-2.31f, 2.33f), 5f, 0.0f);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(banana, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
            }
        }
    }

    void FixedUpdate()
    {
     
        score += Time.deltaTime;
        timerText.text = "Score: 0" + Mathf.RoundToInt (score);
     
    }
}
    