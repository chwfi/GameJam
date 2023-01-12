using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [Header("Stat")]
    public float playerSpeed = 5f;

    [SerializeField]
    [Header("Boolean")]
    bool angle1 = true;
    bool angle2 = false;
    bool canMove = true;
    public bool isDestroy;

    [Header("GameObjects")]
    public GameObject[] square;
    public GameObject blow;
    public GameObject GameOverScreen;
    public GameObject ClearScreen;
    public GameObject Squares;

    [Header("Audio")]
    public AudioSource BGM;

    [Header("UI")]
    [SerializeField] Text percent;

    [SerializeField] private float endTime;
    [SerializeField] private float startTime;

    Rigidbody rigid;

    [SerializeField] Animator anim;

    private void Start()
    {
        BGM = gameObject.GetComponent<AudioSource>();
        rigid = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(End());
        StartCoroutine(StartSong());
    }

    private IEnumerator StartSong()
    {
        yield return new WaitForSeconds(startTime);
        BGM.Play();
        yield break;
    }

    private IEnumerator End()
    {
        yield return new WaitForSeconds(endTime); //노래가 끝나는 초
        anim.SetTrigger("End");
        canMove = false;
        percent.gameObject.SetActive(false);
        ClearScreen.SetActive(true);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0) && canMove == true)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (angle1 == true)
                {
                    transform.localEulerAngles = new Vector3(0, 45, 0);
                    angle1 = false;
                    angle2 = true;
                }
                else if (angle2 == true)
                {
                    transform.localEulerAngles = new Vector3(0, -45, 0);
                    angle1 = true;
                    angle2 = false;
                }
            }
        }

        if (isDestroy == true)
        {
            if (Input.GetMouseButtonDown(0) && canMove == true)
            {
                StartCoroutine(Destroy());
                isDestroy = false;
            }
        }
        else if (isDestroy == false)
        {
            if (Input.GetMouseButtonDown(0) && canMove == true)
            {
                rigid.useGravity = true;
                Invoke("DestroyPlayer", 1f);
            }
        }
    }

    public void DestroyPlayer()
    {
        DD();
        percent.gameObject.SetActive(false);
        Invoke("MovePercent", 1.215f);
        GameOverScreen.SetActive(true);
        gameObject.SetActive(false);
    }

    void MovePercent()
    {
        percent.gameObject.SetActive(true);
        percent.fontSize = 115;
        percent.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 42);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Square"))
        {
            isDestroy = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Square"))
        {
            if (isDestroy == true)
            {
                rigid.useGravity = true;
                Invoke("DestroyPlayer", 1f);
            }
        }
    }

    public void DD()
    {
        try
        {
            GameObject.Find("Percent").GetComponent<Percentage>().Over_Loading();
        }
        catch (NullReferenceException)
        {

        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.01f);
        //GameOver();
        //Destroy(FindNearestObjectByTag("Square"));
        FindNearestObjectByTag("Square").SetActive(false);
    }

    public GameObject neareastEnemy;
    private GameObject FindNearestObjectByTag(string tag)
    {
        // 탐색할 오브젝트 목록을 List 로 저장합니다.
        var objects = GameObject.FindGameObjectsWithTag(tag).ToList();

        // LINQ 메소드를 이용해 가장 가까운 적을 찾습니다.
        var neareastObject = objects
            .OrderBy(obj =>
            {
                return Vector3.Distance(transform.position, obj.transform.position);
            })
        .FirstOrDefault();

        return neareastObject;
    }
}
