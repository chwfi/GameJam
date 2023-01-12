using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void PauseSound()
    {
        musicSource.Pause();
    }

    public void UnPauseSound()
    {
        musicSource.UnPause();
    }
}
