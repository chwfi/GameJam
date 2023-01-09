using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 0f;
    bool angle1 = true;
    bool angle2 = false;
    bool canMove = true;

    bool start = true;

    private void Start()
    {
        playerSpeed = 0f;
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && start == true || Input.GetMouseButtonDown(0) && start == true)
        {
            playerSpeed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
        {
            if (angle1 == true)
            {
                transform.localEulerAngles = new Vector3(0, -45, 0);
                angle1 = false;
                angle2 = true;
            }
            else if (angle2 == true)
            {
                transform.localEulerAngles = new Vector3(0, 45, 0);
                angle1 = true;
                angle2 = false;
            }
        }
    }
}
