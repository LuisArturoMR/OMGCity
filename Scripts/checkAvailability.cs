using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkAvailability : MonoBehaviour
{

    public Button[] upgrades;
    private string[] stringLevels = {"sewerLevel", "policeLevel", "firefighterLevel", "hospitalLevel", "ecologyLevel",
        "jobsLevel", "laneLevel", "rampLevel", "transportLevel", "luminaryLevel", "bikewayLevel"};
    private int[] levelsPerFactor = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0 };
    private int[,] prices = { { 20, 30 }, { 30, 40 }, { 50, 60 }, { 70, 80 }, { 90, 100 }, { 110, 120 }, { 130, 140 }, { 150, 160 }, { 170, 180 }, { 190, 200 }, { 210, 220 } };

    // Use this for initialization
    void Start()
    {
        this.checkLevels();
        //PlayerPrefs.SetInt("credit", 2000);
        //print(prices[0, 0]);
        //print(prices[0, 1]);
        //print(prices[1, 0]);
        //print(prices[1, 1]);
        //print(prices[2, 0]);
        //print(prices[2, 1]);
        //print(prices[3, 0]);
        //print(prices[3, 1]);
        //print(prices[4, 0]);
        //print(prices[4, 1]);
        //print(prices[5, 0]);
        //print(prices[5, 1]);
        //print(prices[6, 0]);
        //print(prices[6, 1]);
        //print(prices[7, 0]);
        //print(prices[7, 1]);
        //print(prices[8, 0]);
        //print(prices[8, 1]);
        //print(prices[9, 0]);
        //print(prices[9, 1]);
        //print(prices[10, 0]);
        //print(prices[10, 1]);


    }

    // Update is called once per frame
    void Update()
    {
        this.checkLevels();

    }

    public void checkLevels()
    {

        for (int i = 0; i < stringLevels.Length; i++)
        {
            if (PlayerPrefs.GetInt(stringLevels[i]) > levelsPerFactor[i])
            {
                upgrades[i].interactable = false;
            }
            else
            {
                if (PlayerPrefs.GetInt("credit") > prices[i, PlayerPrefs.GetInt(stringLevels[i])])
                {
                    //PlayerPrefs.SetInt("credit", prices[i, PlayerPrefs.GetInt(stringLevels[i])]);
                    upgrades[i].interactable = true;

                }
                else
                {
                    upgrades[i].interactable = false;
                }
            }
        }
    }

    public void buy(int index)
    {
        print(index);
        if (PlayerPrefs.GetInt("credit") >= prices[index, PlayerPrefs.GetInt(stringLevels[index])])
        {
            //PlayerPrefs.SetInt("credit", PlayerPrefs.GetInt("credit") - prices[index, PlayerPrefs.GetInt(stringLevels[index])]);
            print(PlayerPrefs.GetInt("credit"));

        }
        else
        {
            upgrades[index].interactable = false;
        }

        this.checkLevels();
        //print(PlayerPrefs.GetInt("credit"));
    }
}
