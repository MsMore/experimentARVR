using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class buttons : MonoBehaviour
{
    private GameObject Cube;
    private GameObject Plane;
    private GameObject Sphere;
    [SerializeField] private Material[] materials;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Cube");
        Plane = GameObject.Find("Plane");
        Sphere = GameObject.Find("Sphere");
    }
    public void OnClickCubeButton()
    {
        Cube.GetComponent<Renderer>().material = materials[Random.Range(0, materials.Length)];
    }
    public void OnClickPlaneButton()
    {
        Plane.GetComponent<Renderer>().material = materials[Random.Range(0, materials.Length)];
    }
    public void OnClickSphereButton()
    {
        Sphere.GetComponent<Renderer>().material = materials[Random.Range(0, materials.Length)];
    }

}
