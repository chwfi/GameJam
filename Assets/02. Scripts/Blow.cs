using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{
    Animator anim;
    [SerializeField] float endTime;
    bool canBlow = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(End());
    }
    private IEnumerator End()
    {
        yield return new WaitForSeconds(endTime);
        canBlow = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canBlow == true || Input.GetMouseButtonDown(0) && canBlow == true)
        {
            anim.SetTrigger("Blow");
        }
    }
}
