using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCtrl : MonoBehaviour
{
    GameRule gameRule;
    public Text score;

    private void Awake()
    {
        gameRule = FindObjectOfType<GameRule>();
    }
    private void Update()
    {
        score.text = gameRule.score.ToString();
    }
}
