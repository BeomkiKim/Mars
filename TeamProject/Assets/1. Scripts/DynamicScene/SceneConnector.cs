using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConnector : MonoBehaviour
{
    public GameObject missionUI;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            missionUI.SetActive(true);
        }
    }

    public void GoMission()
    {
        SceneManager.LoadScene("FlyingScene", LoadSceneMode.Single);
    }
    public void NoMission()
    {
        missionUI.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
