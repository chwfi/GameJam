using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    [System.Serializable]
    public class LevelDataProperty
    {
        public Sprite levelSprite;
        public string levelName;
        public string artistName;
    }

    [SerializeField] Button _previousButton;
    [SerializeField] Button _nextButton;
    [SerializeField] Button _startButton;
    [SerializeField] Image _stageImage;
    [SerializeField] Text _stageName;
    [SerializeField] Text _name;
    [SerializeField] MenuManager _sceneManager;
    [SerializeField] GameObject _difficulty01;
    [SerializeField] GameObject _difficulty02;
    [SerializeField] GameObject _difficulty03;
    [SerializeField] GameObject _difficulty04;
    [SerializeField] GameObject _difficulty05;

    public List<LevelDataProperty> mapData;

    public int currentPage;
    public int definitionInt = 1;


    private void Update()
    {
        UpdateUI();

        if (currentPage == 0)
        {
            _difficulty01.SetActive(true);
            _difficulty02.SetActive(false);
            _difficulty03.SetActive(false);
            _difficulty04.SetActive(false);
            _difficulty05.SetActive(false);
        }
        if (currentPage == 1)
        {
            _difficulty02.SetActive(true);
            _difficulty01.SetActive(false);
            _difficulty03.SetActive(false);
            _difficulty04.SetActive(false);
            _difficulty05.SetActive(false);
        }
        if (currentPage == 2)
        {
            _difficulty03.SetActive(true);
            _difficulty02.SetActive(false);
            _difficulty01.SetActive(false);
            _difficulty04.SetActive(false);
            _difficulty05.SetActive(false);
        }
        if (currentPage == 3)
        {
            _difficulty04.SetActive(true);
            _difficulty02.SetActive(false);
            _difficulty03.SetActive(false);
            _difficulty01.SetActive(false);
            _difficulty05.SetActive(false);
        }
        if (currentPage == 4)
        {
            _difficulty05.SetActive(true);
            _difficulty02.SetActive(false);
            _difficulty03.SetActive(false);
            _difficulty04.SetActive(false);
            _difficulty01.SetActive(false);
        }
    }

    public void OnClickStart()
    {
        if (currentPage == 0)
        {
            _sceneManager.MoveStage01();
        }
        if (currentPage == 1)
        {
            _sceneManager.MoveStage02();
        }
        if (currentPage == 2)
        {
            _sceneManager.MoveStage03();
        }
        if (currentPage == 3)
        {
            _sceneManager.MoveStage04();
        }
        if (currentPage == 4)
        {
            _sceneManager.MoveStage05();
        }
    }

    public void UpdateUI()
    {
        _previousButton.interactable = currentPage > 0;
        _nextButton.interactable = currentPage < mapData.Count - 1;

        UpdateContents();
    }

    public void UpdateContents()
    {
        _stageImage.sprite = mapData[currentPage].levelSprite;
        _stageName.text = mapData[currentPage].levelName;
        _name.text = mapData[currentPage].artistName;
    }

    public void OnClickPrevious()
    {
        currentPage--;
        UpdateUI();
    }

    public void OnClickNext()
    {
        currentPage++;
        UpdateUI();
    }
}
