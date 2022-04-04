using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidState : MonoBehaviour
{
    public int hp;
    public int hpCur;

    GameRule gameRule;

    private void Awake()
    {
        gameRule = FindObjectOfType<GameRule>();
        hpCur = hp;
    }
    private void Update()
    {
        if(hpCur <=0)
        {
            gameRule.score += 1;
            Destroy(gameObject);
        }
    }
}
