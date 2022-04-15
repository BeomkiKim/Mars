using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvController : MonoBehaviour
{
    public GameObject tvScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tvScreen.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            tvScreen.SetActive(false);
        }
    }
}
