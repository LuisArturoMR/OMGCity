using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update(){
    }

    void lluvia(){
        float currentEcology = PlayerPrefs.GetFloat("currEcology");
        float minimumEcology = PlayerPrefs.GetFloat("minEcology");
        float currentPollution = PlayerPrefs.GetFloat("currPollution");
        float maximumPollution = PlayerPrefs.GetFloat("maxPollution");

        float diffEcology = (currentEcology - minimumEcology)/3;
        float diffPollution = (currentPollution - maximumPollution)/3;

        float avg = (diffEcology - diffPollution)/2;

        int rand = Random.Range(1, 100);

        if((50+ avg * 5) < rand){

            //hacer que llueva
            
        }

    }

    void crimen() { 
        float currentHealthLevel = PlayerPrefs.GetFloat("currHealthLevel");
        float minimumHealthLevel = PlayerPrefs.GetFloat("minHealthLevel");
        float currentHappinessLevel = PlayerPrefs.GetFloat("currHappinessLevel");
        float minimumHappinessLevel = PlayerPrefs.GetFloat("minHappinessLevel");
        float currentEconomy = PlayerPrefs.GetFloat("currHappinessLevel");
        float minimumEconomy = PlayerPrefs.GetFloat("minHappinessLevel");
        float currentSocial = PlayerPrefs.GetFloat("currSocial");
        float minimumSocial = PlayerPrefs.GetFloat("minSocial");
        float currentSecurity = PlayerPrefs.GetFloat("currSecurity");
        float minimumSecurity = PlayerPrefs.GetFloat("minSecurity");

        float diffHealth = (currentHealthLevel + minimumHealthLevel) / 3;
        float diffHappiness = (currentHappinessLevel + minimumHappinessLevel) / 3;
        float diffEconomy = (currentEconomy + minimumEconomy) / 3;
        float diffSocial = (currentSocial + minimumSocial) / 3;
        float diffSecurity = (currentSecurity + minimumSecurity) / 3;

        float avg = (diffHealth + diffHappiness + diffEconomy + diffSocial + diffSecurity) / 2;

        int rand = Random.Range(1, 100);

        if ((50 + avg * 5) < rand)
        {

            //hacer que haya crimen

        }
    }


    void incendio(){
        float currentEcology = PlayerPrefs.GetFloat("currEcology");
        float minimumEcology = PlayerPrefs.GetFloat("minEcology");
        float currentPollution = PlayerPrefs.GetFloat("currPollution");
        float minimumPollution = PlayerPrefs.GetFloat("minPollution");

        float diffEcology = (currentEcology - minimumEcology) / 3;
        float diffPollution = (currentPollution - minimumPollution) / 3;

        float avg = (diffEcology - diffPollution) / 2;

        int rand = Random.Range(1, 100);

        if ((50 + avg * 5) < rand)
        {

            //hacer que haya incendios

        }
        
            
    }

    void enfermedades(){
        
        float currentHealthLevel = PlayerPrefs.GetFloat("currHealthLevel");
        float minimumHealthLevel = PlayerPrefs.GetFloat("minHealthLevel");
        float currentFloodCap = PlayerPrefs.GetFloat("currFloodCap");
        float minimumFloodCap = PlayerPrefs.GetFloat("minFloodCap");
        float currentPollution = PlayerPrefs.GetFloat("currPollution");
        float maximumPollution = PlayerPrefs.GetFloat("maxPollution");
        float currentAccessibility = PlayerPrefs.GetFloat("currAccessibility");
        float minimumAccessibility = PlayerPrefs.GetFloat("minAccessibility");
        float currentEconomy = PlayerPrefs.GetFloat("currEconomy");
        float minimumEconomy = PlayerPrefs.GetFloat("minEconomy");

        float diffHealth = (currentHealthLevel + minimumHealthLevel) / 3;
        float diffFlood = (currentFloodCap + minimumFloodCap) / 3;
        float diffPollution = (currentPollution - maximumPollution) / 3;
        float diffAccesibility = (currentAccessibility + minimumAccessibility) / 3;
        float diffEconomy = (currentEconomy + minimumEconomy) / 3;

        float avg = (diffHealth + diffFlood - diffPollution + diffAccesibility + diffEconomy) / 2;

        int rand = Random.Range(1, 100);

        if ((50 + avg * 5) < rand)
        {

            //hacer que haya enfermedades

        }
    }
}
