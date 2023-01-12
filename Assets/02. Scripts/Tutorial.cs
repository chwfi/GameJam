using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public bool isTutorial;

    [SerializeField] private GameObject tutoPanel;

    AudioSource tutoMusic;

    private void Start()
    {
        tutoMusic = GetComponent<AudioSource>();
        isTutorial = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Square") && isTutorial)
        {
            Invoke("TutorialPanelOn", 0.1f);
        }
    }

    private void TutorialPanelOn()
    {
        Time.timeScale = 0;
        tutoMusic.Pause();
        tutoPanel.SetActive(true);
        isTutorial = false;
    }

    public void TutorialPanelOff()
    {
        Time.timeScale = 1;
        tutoMusic.Play();
        tutoPanel.SetActive(false);
    }
}
