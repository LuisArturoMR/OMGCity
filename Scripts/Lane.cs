using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    // Use this for initialization

    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("laneLevel") == 0)
        {
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.0164f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.0384f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * (1 - 0.024f));
            PlayerPrefs.SetInt("laneLevel", PlayerPrefs.GetInt("laneLevel") + 1);
        }

    }
}