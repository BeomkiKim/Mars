using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{
    public void clickPlay()
    {
        SceneManager.LoadScene("DynamicScene");
    }
    public void clickMain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }
    public void clickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
