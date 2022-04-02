using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    public int hp;
    public int hpCur;

    public GameObject[] life;
    public int lifeCount;
    public GameObject dieUI;
    public GameObject dieUi;
    public GameObject[] fireEffect;

    private void Start()
    {
        hpCur = hp;
        lifeCount = hp-1;
    }
    private void Update()
    {
        if(hpCur <= 0)
        {
            StartCoroutine("DieUIActive");
        }
    }
    void Damage()
    {
        hpCur -= 1;
        fireEffect[lifeCount].SetActive(true);
        life[lifeCount].SetActive(false);
        lifeCount -= 1;
    }
    IEnumerator DieUIActive()
    {
        yield return new WaitForSeconds(1.0f);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        dieUI.SetActive(true);
        dieUi.SetActive(true);
    }
}
