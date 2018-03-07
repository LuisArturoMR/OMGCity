using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void nextLevel(){
        if (PlayerPrefs.GetInt("hospitalLevel") == 0)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.17f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.59f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.67f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * (1 - 0.0268f));
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.12f);

            PlayerPrefs.SetInt("hospitalLevel", PlayerPrefs.GetInt("hospitalLevel") + 1);

        }

        else if (PlayerPrefs.GetInt("hospitalLevel") == 1)
        {
            PlayerPrefs.SetFloat("currSocial", PlayerPrefs.GetFloat("currSocial") * 1.21f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.07f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.05f);
            PlayerPrefs.SetFloat("currEcology", PlayerPrefs.GetFloat("currEcology") * (1 - 0.0123f));
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.1f);

            PlayerPrefs.SetInt("hospitalLevel", PlayerPrefs.GetInt("hospitalLevel") + 1);


        }
    }
}
