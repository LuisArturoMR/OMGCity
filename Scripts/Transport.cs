using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    // Use this for initialization

    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("transportLevel") == 0)
        {
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.0312f));
            PlayerPrefs.SetFloat("currAccessibility", PlayerPrefs.GetFloat("currAccessibility") * 1.0274f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 01.0364f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 01.0487f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * (1 - 0.0322f));
            PlayerPrefs.SetInt("transportLevel", PlayerPrefs.GetInt("transportLevel") + 1);
        }

        else if (PlayerPrefs.GetInt("transportLevel") == 1)
        {
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.0245f));
            PlayerPrefs.SetFloat("currAccessibility", PlayerPrefs.GetFloat("currAccessibility") * 1.0324f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 01.0424f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 01.0617f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * (1 - 0.0265f));
            PlayerPrefs.SetInt("transportLevel", PlayerPrefs.GetInt("transportLevel") + 1);
        }
    }
}