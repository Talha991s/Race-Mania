using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aifinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RaceFinish"))
        {
            Debug.Log("AI WOn");
        }
    }

}
