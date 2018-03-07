 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFighter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("firefighterLevel") == 0)
        {
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 1.026f);
            PlayerPrefs.SetFloat("currSecurity", PlayerPrefs.GetFloat("currSecurity") * 1.22f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.10f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.26f);

            PlayerPrefs.SetInt("firefighterLevel", PlayerPrefs.GetInt("firefighterLevel") + 1);

        }

        else if (PlayerPrefs.GetInt("firefighterLevel") == 1)
        {
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 1.013f);
            PlayerPrefs.SetFloat("currSecurity", PlayerPrefs.GetFloat("currSecurity") * 1.024f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.021f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.053f);

            PlayerPrefs.SetInt("firefighterLevel", PlayerPrefs.GetInt("firefighterLevel") + 1);

        }
    }

}
