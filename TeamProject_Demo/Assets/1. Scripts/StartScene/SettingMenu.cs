using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public Slider volumSlider;


    FullScreenMode screenMode;
    List<Resolution> resolutions = new List<Resolution>();
    public Dropdown resolutionDropdown;
    public Toggle fullscreen;
    public int resolutionNum;


    private void Start()
    {

        Screen.SetResolution(1920, 1080, true);
        initUi();
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }
    }
    public void setVolum()
    {
        AudioListener.volume = volumSlider.value;
        save();
    }
    void load()
    {
        volumSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    void save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumSlider.value);
    }

    void initUi()
    {
        for(int i =0; i<Screen.resolutions.Length; i++)
        {
            if (Screen.resolutions[i].refreshRate == 60)
                resolutions.Add(Screen.resolutions[i]);
        }

        resolutionDropdown.options.Clear();

        int optionNum = 0;
        foreach(Resolution item in resolutions)
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " " + item.refreshRate;
            resolutionDropdown.options.Add(option);

            if (item.width == Screen.width && item.height == Screen.height)
                resolutionDropdown.value = optionNum;
            optionNum++;

        }
        resolutionDropdown.RefreshShownValue();

        fullscreen.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
    }

    public void dropBoxOptionChange(int x)
    {
        resolutionNum = x;
    }

    public void fullScreen()
    {
        screenMode = fullscreen.isOn ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;

    }

    public void okClick()
    {
        Screen.SetResolution(resolutions[resolutionNum].width,
            resolutions[resolutionNum].height,
            screenMode);
        Time.timeScale = 1;
    }

}
