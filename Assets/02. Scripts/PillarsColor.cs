using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PillarsColor : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        for (int i = 0; i < 10; i++)
        {
            rend.material.DOColor(Color.HSVToRGB(0.00278f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.0278f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.0556f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.084f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.11f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.167f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.195f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.222f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.25f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.277f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.3056f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.333f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.361f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.389f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.416f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.444f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.472f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.5f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.5248f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.555f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.583f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.6111f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.638f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.6667f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.6944f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.7222f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.754f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.783f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.81f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.8433f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.87556f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.91667f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.9444f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(0.97222f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
            rend.material.DOColor(Color.HSVToRGB(1f, 0.6f, 0.75f), 2f);
            yield return new WaitForSeconds(2f);
        }
    }
}

