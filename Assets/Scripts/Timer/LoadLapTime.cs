using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public int millisecond;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    // Start is called before the first frame update
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("minSave");
        SecCount = PlayerPrefs.GetInt("mecSave");
        millisecond = PlayerPrefs.GetInt("milliSave");

        MinDisplay.GetComponent<TMP_Text>().text = "0" + MinCount + ":";
        SecDisplay.GetComponent<TMP_Text>().text = "" + SecCount + ":";
        MilliDisplay.GetComponent<TMP_Text>().text = "" + millisecond;
    }

}
