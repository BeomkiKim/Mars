using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCtrl : MonoBehaviour
{
    AsteroidState asteroidState;

    private void Awake()
    {
        asteroidState = GetComponent<AsteroidState>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.SendMessage("Damage");
            Destroy(gameObject);
        }
    }
    void Damage()
    {
        asteroidState.hpCur -= 1;
    }
}
