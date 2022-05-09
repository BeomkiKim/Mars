using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject setting;
    public GameObject buttons;


    public void clickSetting()
    {
        setting.SetActive(true);
        buttons.SetActive(false);
    }
    public void clickApply()
    {
        buttons.SetActive(true);
        setting.SetActive(false);  
    }

    public void timeSet()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void timeReset()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
