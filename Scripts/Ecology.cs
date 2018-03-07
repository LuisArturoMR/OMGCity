using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecology : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void nextLevel(){
        if (PlayerPrefs.GetInt("ecologyLevel") == 0)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.055f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.045f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.035f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 1.23f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.042f);
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.33f));


            PlayerPrefs.SetInt("ecologyLevel", PlayerPrefs.GetInt("ecologyLevel") + 1);

        }

        else if (PlayerPrefs.GetInt("ecologyLevel") == 1)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.068f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.055f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.025f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 1.14f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.045f);
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.19f));

            PlayerPrefs.SetInt("ecologyLevel", PlayerPrefs.GetInt("ecologyLevel") + 1);
        }

        else if (PlayerPrefs.GetInt("ecologyLevel") == 2)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.02f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.034f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.018f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * 1.22f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.027f);
            PlayerPrefs.SetFloat("currPollution", PlayerPrefs.GetFloat("currPollution") * (1 - 0.24f));

            PlayerPrefs.SetInt("ecologyLevel", PlayerPrefs.GetInt("ecologyLevel") + 1);
        }
    }
}
