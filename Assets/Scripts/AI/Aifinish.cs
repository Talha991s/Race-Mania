using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class Aifinish : MonoBehaviour
{
    [SerializeField]private int numberoflapCompleted = 0;
    //public GameObject LoseScreen;
    //public GameObject MyCar;
    //public GameObject LevelMusic;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AI"))
        {
            numberoflapCompleted += 1;
            Debug.Log("AI WOn");
            if(numberoflapCompleted == 4)
            {
                Debug.Log("DONE");
                SceneManager.LoadScene(4);
                //LoseScreen.SetActive(true);
                //CarController.m_Topspeed = 0.0f;
                //MyCar.GetComponent<CarController>().enabled = false;
                //MyCar.GetComponent<CarUserControl>().enabled = false;
                //LevelMusic.SetActive(false);
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("AI"))
    //    {
    //        Debug.Log("AI WOn");
    //    }
    //}
}
