using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static int milli;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public static float raw;
    public static int RawTime;

    private void Start()
    {
        MinuteCount = 0;
        SecondCount = 0;
        MilliCount = 0;
        RawTime = 0;
    }

    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        raw += Time.deltaTime;
        RawTime = (int)raw;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<TMP_Text>().text = "" + MilliDisplay; 
        milli = (int)MilliCount;

        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if(SecondCount <= 9 )
        {
            SecondBox.GetComponent<TMP_Text>().text = "0" + SecondCount + ":";
        }
        else
        {
            SecondBox.GetComponent<TMP_Text>().text = "" + SecondCount + ":";
        }
        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }
        if(MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TMP_Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<TMP_Text>().text = "" + MinuteCount + ":";
        }
    }
}
