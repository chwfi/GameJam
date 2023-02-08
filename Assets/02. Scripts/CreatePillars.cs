using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePillars : MonoBehaviour
{
    public GameObject[] pillars;
    public GameObject pillar;

    public int bpm = 0;
    double currentTime = 0d;

    int i = 1;
    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > 60d / bpm)
        {
            pillars[i].SetActive(true);
            currentTime -= 60d / bpm;
            i++;
        }
    }
}
