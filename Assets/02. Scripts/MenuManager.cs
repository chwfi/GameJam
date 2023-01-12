using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingPanel;
    public SoundManager soundManager;

    public void ClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClickSetting()
    {
        Time.timeScale = 0;
        soundManager.PauseSound();
        settingPanel.SetActive(true);
    }

    public void ClickRe()
    {
        Time.timeScale = 1;
        soundManager.UnPauseSound();
        settingPanel.SetActive(false);
    }

    public void ClickMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuToGameStage01()
    {
        SceneManager.LoadScene(1);
    }
}
