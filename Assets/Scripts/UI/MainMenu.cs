using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class MainMenu : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject Laptimemanger;
    //public AudioSource LevelMusic;
    //public void StartGame()
    //{
    //    SceneManager.LoadScene(2);
    //}

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //CarController.m_Topspeed = 200.0f;
        //MyCar.GetComponent<CarController>().enabled = true;
        //MyCar.GetComponent<CarUserControl>().enabled = true;

        //Laptimemanger.GetComponent<LapTimeManager>().enabled = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Track01()
    {
        SceneManager.LoadScene(2);
        CarController.m_Topspeed = 200.0f;
        MyCar.GetComponent<CarController>().enabled = true;
        MyCar.GetComponent<CarUserControl>().enabled = true;

        //Laptimemanger.GetComponent<LapTimeManager>().enabled = true;
    }
    public void Track02()
    {
        SceneManager.LoadScene(3);
        CarController.m_Topspeed = 200.0f;
        MyCar.GetComponent<CarController>().enabled = true;
        MyCar.GetComponent<CarUserControl>().enabled = true;
        //Laptimemanger.GetComponent<LapTimeManager>().enabled = true;
    }
    public void BacktoMain()
    {
        //CarController.m_Topspeed = 200.0f;
        ////MyCar.GetComponent<CarController>().enabled = true;
        //MyCar.GetComponent<CarUserControl>().enabled = true;
        //Laptimemanger.GetComponent<LapTimeManager>().enabled = true;
        SceneManager.LoadScene(0);
    }

    //public void Restart()
    //{
    //    SceneManager.LoadScene(2);
    //    CarController.m_Topspeed = 200.0f;
    //    MyCar.GetComponent<CarController>().enabled = true;
    //    MyCar.GetComponent<CarUserControl>().enabled = true;
    //    LevelMusic.Play();
    //}

}
