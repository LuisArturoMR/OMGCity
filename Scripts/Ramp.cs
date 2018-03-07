using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour
{
    // Use this for initialization

    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("rampLevel") == 0)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.042f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 01.0164f);
            PlayerPrefs.SetInt("rampLevel", PlayerPrefs.GetInt("rampLevel") + 1);
        }

    }
}