using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcantarilla : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    public void nextLevel(){
        if (PlayerPrefs.GetInt("sewerLevel") == 0)
        {
            PlayerPrefs.SetFloat("currFloodCap", PlayerPrefs.GetFloat("currFloodCap") * 1.035f);
            PlayerPrefs.SetFloat("currHealthLevel", PlayerPrefs.GetFloat("currHealthLevel") * 1.078f);
            PlayerPrefs.SetFloat("currHappinessLevel", PlayerPrefs.GetFloat("currHappinessLevel") * 1.0092f);
            PlayerPrefs.SetFloat("currEconomy", PlayerPrefs.GetFloat("currEconomy") * 1.025f);

            PlayerPrefs.SetInt("sewerLevel", PlayerPrefs.GetInt("sewerLevel") + 1);
        }
    }

}