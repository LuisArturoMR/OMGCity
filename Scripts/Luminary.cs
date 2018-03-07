using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luminary : MonoBehaviour
{
    // Use this for initialization

    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("luminaryLevel") == 0)
        {
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.0135f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 01.0123f);
            PlayerPrefs.SetFloat("currSecurity", PlayerPrefs.GetFloat("currSecurity") * 01.0223f);
            PlayerPrefs.SetInt("luminaryLevel", PlayerPrefs.GetInt("luminaryLevel") + 1);
        }

    }
}