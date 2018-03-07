using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour {
    GameObject[] redSpheres;
    GameObject[] greenSpheres;
    public GameObject cubo;
    void Start ()
    {
        redSpheres = GameObject.FindGameObjectsWithTag("RedSphere");
        greenSpheres = GameObject.FindGameObjectsWithTag("GreenSphere");
        foreach (GameObject x in redSpheres)
        {
            x.SetActive(false);
        }
    }

    public void callInvoke()
    {
        Invoke("showObjects", 3);
    }

    public void showObjects()
    {
        foreach (GameObject x in redSpheres)
        {
            x.SetActive(true);
        }
    }

    public void replaceObjects()
    {
        foreach (GameObject x in greenSpheres)
        {
            Instantiate(cubo, x.transform.position, x.transform.rotation);
            Destroy(x);
        }

    }
}

