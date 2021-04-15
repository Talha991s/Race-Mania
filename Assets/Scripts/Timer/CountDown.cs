using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CountDown : MonoBehaviour
{
    public AudioSource LevelMusic;
    public GameObject Countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject StartBlock;
    public GameObject BackBlock;
    

    // Start is called before the first frame update
    void Start()
    {
       // CarControls.GetComponent<GameObject>();
        StartCoroutine(Countstart());
        

    }

    IEnumerator Countstart()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<TMP_Text>().text = "3";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Countdown.SetActive(false);

        Countdown.GetComponent<TMP_Text>().text = "2";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Countdown.SetActive(false);

        Countdown.GetComponent<TMP_Text>().text = "1";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Countdown.SetActive(false);

        GoAudio.Play();

        LapTimer.SetActive(true);
        StartBlock.SetActive(false);
        LevelMusic.Play();
        BackBlock.SetActive(false);
        //CarControls.SetActive(true);
    }
}
