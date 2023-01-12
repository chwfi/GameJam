using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    Tutorial tutorial;
    // Start is called before the first frame update
    void Start()
    {
        tutorial = GameObject.Find("Player").GetComponent<Tutorial>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            tutorial.TutorialPanelOff();
        }   
    }
}
