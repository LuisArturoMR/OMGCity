using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("policeLevel") == 0)
        {
            PlayerPrefs.SetFloat("currSecurity", PlayerPrefs.GetFloat("currSecurity") * 1.35f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.028f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 0.9948f);

            PlayerPrefs.SetInt("policeLevel", PlayerPrefs.GetInt("policeLevel") + 1);

        }

        else if (PlayerPrefs.GetInt("policeLevel") == 1)
        {
            PlayerPrefs.SetFloat("currSecurity", PlayerPrefs.GetFloat("currSecurity") * 1.1f);
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.048f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 0.99f);

            PlayerPrefs.SetInt("policeLevel", PlayerPrefs.GetInt("policeLevel") + 1);


        }
    }
}


