using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effect;
    private void Start()
    {
        StartCoroutine("DelayDestroy");
    }
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 1000;


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.SendMessage("Damage");
            effectSpawn();

        }
    }
    void effectSpawn()
    {
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
}
