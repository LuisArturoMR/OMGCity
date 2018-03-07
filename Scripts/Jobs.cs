using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jobs : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("jobsLevel") == 0)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * (1 - 0.013f));
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * (1 - 0.068f));
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.25f);

            PlayerPrefs.SetInt("jobsLevel", PlayerPrefs.GetInt("jobsLevel") + 1);
        }
    }
}
