using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOB : MonoBehaviour
{
    Goal g;
    public Transform startPos;

    private void Start()
    {
        g = GameObject.Find("Goal").GetComponent<Goal>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.transform.position = startPos.position;
            g.score--;
        }
    }
}
