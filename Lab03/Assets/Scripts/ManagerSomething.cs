using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerSomething : MonoBehaviour
{
    // Starter Shit
    public bool pause;
    public bool showPlane;
    public Slider sliderRotate;
    public Slider sliderScale;

    // Bugger
    public GameObject Kyle;
    public GameObject Plane;
    public GameObject[] pauseObjects;

    void Start()
    {
        Time.timeScale = 1;

        Kyle = GameObject.Find("Robot Kyle"); // Get Kyle you stupid piecce of  
        Plane = GameObject.Find("CheckeredPlane");

        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
    }

    void Update()
    {
        if (!pause)
        {
            foreach (GameObject g in pauseObjects)
            {
                g.SetActive(true);
            }
        }

        if (pause)
        {
            foreach (GameObject g in pauseObjects)
            {
                g.SetActive(false);
            }
        }
    } 


    void PauseControls()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void PauseGame()
    {
        if (pause)
        {
            pause = false;
            Time.timeScale = 0;
        }
        else
        {
            pause = true;
            Time.timeScale = 1;
        }
    }

    public void Reload()
    {
        SceneManager.LoadScene(0);
    }

    public void PlaneToggle()
    {
        if (showPlane)
        {
            showPlane = false;
            Plane.SetActive(true);
        }
        else
        {
            showPlane = true;
            Plane.SetActive(false);
        }
    }

    public void SliderRotate()
    {
        Kyle.transform.eulerAngles = new Vector3(0, sliderRotate.value, 0);
    }

    public void SliderScale()
    {
        Kyle.transform.localScale = new Vector3(sliderScale.value, sliderScale.value, sliderScale.value);
    }
}
