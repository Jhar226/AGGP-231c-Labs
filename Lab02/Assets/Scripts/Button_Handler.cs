using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button_Handler : MonoBehaviour, IVirtualButtonEventHandler
{
    [Header("Buttons")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;

    [Header("Button Objects")]
    public GameObject Button_Object1;
    public GameObject Button_Object2;
    public GameObject Button_Object3;
    public GameObject Button_Object4;
    public GameObject Button_Object5;
    public GameObject Button_Object6;

    [Header("Misc")]

    // Materials
    public List<Material> materials;

    // Meshes
    public MeshFilter cube;
    public MeshFilter sphere;

    private void Start()
    {
        Button1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Button2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Button3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Button4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Button5.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Button6.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        // Object 1
        Button_Object1.SetActive(false);

        // Object 2
        Button_Object2.transform.localScale += new Vector3(1, 1, 1);

        // Object 3
        Button_Object3.transform.localScale -= new Vector3(1, 1, 1);

        // Object 4
        Button_Object4.transform.eulerAngles = new Vector3(120, 120, 120);

        // Object 5
        Button_Object5.GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Count)];

        // Object 6
        Button_Object6.GetComponent<MeshFilter>().mesh = sphere.mesh;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Object 1
        Button_Object1.SetActive(true);

        // Object 2
        Button_Object2.transform.localScale -= new Vector3(1, 1, 1);

        // Object 3
        Button_Object3.transform.localScale += new Vector3(1, 1, 1);

        // Object 4
        Button_Object4.transform.eulerAngles = new Vector3(0, 0, 0);

        // Object 6
        Button_Object6.GetComponent<MeshFilter>().mesh = cube.mesh;
    }
}
