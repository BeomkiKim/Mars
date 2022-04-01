using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterState : MonoBehaviour
{
    public float hp;
    public float hpCur;

    private void Start()
    {
        hpCur = hp;
    }

    private void Update()
    {
        if(hpCur <= 0)
        {
            Destroy(gameObject);
        }
    }
}
