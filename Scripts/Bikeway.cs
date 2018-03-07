using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bikeway : MonoBehaviour
{
    // Use this for initialization

    void Start(){
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("bikewayLevel") == 0)
        {
            PlayerPrefs.SetFloat("currTraffic", PlayerPrefs.GetFloat("currTraffic") * (1 - 0.0498f));
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * (1 - 0.0398f));
            PlayerPrefs.SetFloat("currAccessibility", PlayerPrefs.GetFloat("currAccessibility") * 1.0192f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 01.035f);
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.0487f));
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 01.0215f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 01.02f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 01.0415f);
            PlayerPrefs.SetInt("bikewayLevel", PlayerPrefs.GetInt("bikewayLevel") + 1);
        }

    }
}