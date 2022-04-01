using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public void TakeDamage(int damage)
    {
        MonsterState monsterState = transform.root.GetComponent<MonsterState>();
        monsterState.hpCur -= damage;

    }
}
