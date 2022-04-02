using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameRule : MonoBehaviour
{
    public int score;
    public GameObject clearUI;
    public GameObject clearUi;

    private void Awake()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if(score == 10)
        {
            StartCoroutine("ClearUIActive");
            
        }
    }

    IEnumerator ClearUIActive()
    {
        yield return new WaitForSeconds(1.5f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        clearUI.SetActive(true);
        clearUi.SetActive(true);

    }
    public void Clear()
    {
        SceneManager.LoadScene("DynamicScene", LoadSceneMode.Single);
    }
}
