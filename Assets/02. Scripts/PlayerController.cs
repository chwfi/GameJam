using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
    public GameObject Squares;

    [Header("Audio")]
    public AudioSource BGM;

    private void Start()
    {
        BGM = gameObject.GetComponent<AudioSource>();
        BGM.Play();
        StartCoroutine(End());
    }

    private IEnumerator End()
    {
        yield return new WaitForSeconds(180f); //노래가 끝나는 초
        canMove = false;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
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

        if (isDestroy == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
            {
                StartCoroutine(Destroy());
                isDestroy = false;
            }
        }
        else if (isDestroy == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
            {
                DD();
                Squares.SetActive(false);
                GameOverScreen.SetActive(true);
                gameObject.SetActive(false);
            }
        }
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
                DD();
                Squares.SetActive(false);
                GameOverScreen.SetActive(true);
                Destroy(this.gameObject);
            }
        }
    }

    public void DD()
    {
        GameObject.Find("Percent").GetComponent<Percentage>().Over_Loading();
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
