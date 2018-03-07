using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stats : MonoBehaviour
{
    public Text [] global;
    // Use this for initialization
    void Start()
    {
        this.setValues();

    }

    public void printGlobal(){
        
        global[0].text = PlayerPrefs.GetFloat("minFloodCap") + " minFloodCap";
        global[1].text = PlayerPrefs.GetFloat("currFloodCap") + " currFloodCap";

        global[2].text = PlayerPrefs.GetFloat("minHealthLevel") + " minHealthLevel";
        global[3].text = PlayerPrefs.GetFloat("currHealthLevel") + " currHealthLevel";

        global[4].text = PlayerPrefs.GetFloat("minHappinessLevel") + " minHappinessLevel";
        global[5].text = PlayerPrefs.GetFloat("currHappinessLevel") + " currHappinessLevel";

        global[6].text = PlayerPrefs.GetFloat("minEconomy") + " minEconomy";
        global[7].text = PlayerPrefs.GetFloat("currEconomy") + " currEconomy";

        global[8].text = PlayerPrefs.GetFloat("maxTraffic") + " maxTraffic";
        global[9].text = PlayerPrefs.GetFloat("currTraffic") + " currTraffic";

        global[10].text = PlayerPrefs.GetFloat("maxPollution") + " maxPollution";
        global[11].text = PlayerPrefs.GetFloat("currPollution") + " currPollution";

        global[12].text = PlayerPrefs.GetFloat("minEcology") + " minEcology";
        global[13].text = PlayerPrefs.GetFloat("currEcology") + " currEcology";

        global[14].text = PlayerPrefs.GetFloat("minAccessibility") + " minAccessibility";
        global[15].text = PlayerPrefs.GetFloat("currAccessibility") + " currAccessibility";

        global[16].text = PlayerPrefs.GetFloat("minSocial") + " minSocial";
        global[17].text = PlayerPrefs.GetFloat("currSocial") + " currSocial";

        global[18].text = PlayerPrefs.GetFloat("minSecurity") + " minSecurity";
        global[19].text = PlayerPrefs.GetFloat("currSecurity") + " currSecurity";

        global[20].text = PlayerPrefs.GetInt("started") + " started";

    }

    public void setValues(){
        if (PlayerPrefs.GetInt("started") == 0)
        {

            PlayerPrefs.SetInt("credit", 1000);

            PlayerPrefs.SetFloat("economyIndicator", 50.0f);
            PlayerPrefs.SetFloat("happinessIndicator", 50.0f);
            PlayerPrefs.SetFloat("socialIndicator", 50.0f);

            PlayerPrefs.SetFloat("minFloodCap", 10.0f);
            PlayerPrefs.SetFloat("currFloodCap", 10.0f);

            PlayerPrefs.SetFloat("minHealthLevel", 20.0f);
            PlayerPrefs.SetFloat("currHealthLevel", 20.0f);

            PlayerPrefs.SetFloat("minHappinessLevel", 30.0f);
            PlayerPrefs.SetFloat("currHappinessLevel", 45.0f);

            PlayerPrefs.SetFloat("minEconomy", 40.0f);
            PlayerPrefs.SetFloat("currEconomy", 67.0f);

            PlayerPrefs.SetFloat("maxTraffic", 80.0f);
            PlayerPrefs.SetFloat("currTraffic", 32.0f);

            PlayerPrefs.SetFloat("maxPollution", 30.0f);
            PlayerPrefs.SetFloat("currPollution", 10.0f);

            PlayerPrefs.SetFloat("minEcology", 15.0f);
            PlayerPrefs.SetFloat("currEcology", 27.0f);

            PlayerPrefs.SetFloat("minAccessibility", 20.0f);
            PlayerPrefs.SetFloat("currAccessibility", 40.0f);

            PlayerPrefs.SetFloat("minSocial", 35.0f);
            PlayerPrefs.SetFloat("currSocial", 40.0f);

            PlayerPrefs.SetFloat("minSecurity", 10.0f);
            PlayerPrefs.SetFloat("currSecurity", 10.0f);

            PlayerPrefs.SetInt("started", 1);
        }
        this.printGlobal();

    }

    public void deleteValues()
    {
        PlayerPrefs.DeleteAll();
        this.setValues();
    }


	private void Update()
	{

	}

}
