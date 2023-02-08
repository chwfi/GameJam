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
        SceneManager.LoadScene(1);
    }

    public void MoveStage01()
    {
        SceneManager.LoadScene(6);
    }

    public void MoveStage02()
    {
        SceneManager.LoadScene(2);
    }

    public void MoveStage03()
    {
        SceneManager.LoadScene(3);
    }

    public void MoveStage04()
    {
        SceneManager.LoadScene(4);
    }

    public void MoveStage05()
    {
        SceneManager.LoadScene(5);
    }
}
