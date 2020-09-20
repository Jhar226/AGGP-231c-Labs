using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Touch touch;
    Camera cam;

    Goal goaly;

    Vector3 point = new Vector3();

    void Awake()
    {
        goaly = GameObject.FindObjectOfType<Goal>();
    }

    void Start()
    {
        cam = Camera.main;
    }

    void OnGUI()
    {
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.Label("Cube Position: " + gameObject.transform.position);
        GUILayout.Label("Points: " + goaly.score);
        GUILayout.EndArea();
    }

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                gameObject.transform.position = new Vector3(point.x, gameObject.transform.position.y, point.z);
            }
        }
    }
}
