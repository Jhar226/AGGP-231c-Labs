using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Transform startPos;
    public int score;

    public ChangeScene sceneManager;

    private void Awake()
    {
        sceneManager = GameObject.FindObjectOfType<ChangeScene>();
    }

    void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score >= 10)
        {
            sceneManager.MainMenuReturn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.position = startPos.position;

            score++;

            gameObject.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

            Debug.Log("Score: " + score);
        }
    }
}
