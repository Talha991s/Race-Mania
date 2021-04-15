using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewMode;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;
    public GameObject Laptimemanger;
    public GameObject Winscene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            Laptimemanger.GetComponent<LapTimeManager>().enabled = false;
            MyCar.SetActive(true);
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewMode.SetActive(false);
            FinishMusic.Play();
            Winscene.SetActive(true);
        }
       
    }
}
