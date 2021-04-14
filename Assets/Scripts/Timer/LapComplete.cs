using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapCounter;
    public int lapsDone;

    public int RawTime;
    // public GameObject LapTimeBox;

    public GameObject RaceFinish;

    private void Update()
    {
        if(lapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        //if (collider.gameObject.CompareTag("Player"))
        //{
            lapsDone += 1;
        
            RawTime = PlayerPrefs.GetInt("raw");

            if (LapTimeManager.RawTime <= RawTime)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<TMP_Text>().text = "0" + LapTimeManager.SecondCount + ":";
                }
                else
                {
                    SecondDisplay.GetComponent<TMP_Text>().text = "" + LapTimeManager.SecondCount + ":";
                }


                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<TMP_Text>().text = "0" + LapTimeManager.MinuteCount + ":";
                }
                else
                {
                    MinuteDisplay.GetComponent<TMP_Text>().text = "" + LapTimeManager.MinuteCount + ":";
                }

                MilliDisplay.GetComponent<TMP_Text>().text = "0" + LapTimeManager.milli + "";
            }

            PlayerPrefs.SetInt("minSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("secSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetInt("milliSave", LapTimeManager.milli);
            PlayerPrefs.SetInt("raw", LapTimeManager.RawTime);

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;
            LapCounter.GetComponent<TMP_Text>().text = "" + lapsDone;

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        

    }


}
