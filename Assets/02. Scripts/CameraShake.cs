using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class CameraShake : MonoBehaviour
{
    public float ShakeDuration = 1.75f;
    public float ShakeAmplitude;
    public float ShakeFrequency;

    bool canShake = false;

    private float ShakeElapsedTime = 0f;

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;
    void Start()
    {
        virtualCameraNoise = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        StartCoroutine(CameraShakeFirst());

        ShakeAmplitude = 0f;
        ShakeFrequency = 0f;
    }

    IEnumerator CameraShakeFirst()
    {
        yield return new WaitForSeconds(78.7f);
        canShake = true;
        yield return new WaitForSeconds(23f);
        canShake = false;
    }

    void Update()
    {
        if (VirtualCamera != null && virtualCameraNoise != null)
        {
            if (ShakeElapsedTime > 0)
            {
                virtualCameraNoise.m_AmplitudeGain = ShakeAmplitude;
                virtualCameraNoise.m_FrequencyGain = ShakeFrequency;

                ShakeElapsedTime -= Time.deltaTime;
            }
            else
            {
                virtualCameraNoise.m_AmplitudeGain = 0f;
                ShakeElapsedTime = 0f;
            }
        }

        if (canShake)
        {
            ShakeAmplitude = 2f;
            ShakeFrequency = 2.5f;
            ShakeElapsedTime = ShakeDuration;
        }
    }
}

