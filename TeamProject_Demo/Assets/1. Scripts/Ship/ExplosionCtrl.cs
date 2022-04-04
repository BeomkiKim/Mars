using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine("Active");
    }

    IEnumerator Active()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
