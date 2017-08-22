using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Inspecter Variables

    public GameObject HomeGroup;

    public GameObject Beach;
    public GameObject Column;
    public GameObject Cloud1;
    public GameObject Cloud2;

    public Text P1ScoreText;
    public Text P2ScoreText;
    public int P1Score = 0;
    public int P2Score = 0;

    public bool isGameActive = false;
    public bool isPrepare = false;
    public bool isEnd = false;

    #endregion Inspecter Variables

    [HideInInspector]
    private static float Clouds_MOVING_SPEED = .05f;

    private void Start()
    {
        HomeGroup.SetActive(false);
        PrePareView();
        Update();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            if (!isGameActive && isEnd)
                ResetGame();
            else
                StartGame();
        }

        if (P1Score > 5 || P2Score > 5)
        {
            EndGame();
        }
    }

    private void PrePareView()
    {
        HomeGroup.SetActive(true);
        isPrepare = true;
    }

    public void StartGame()
    {
        isGameActive = true;
        isPrepare = false;
        HomeGroup.SetActive(false);
        StartCoroutine("BackgroundMoving");
    }

    public void EndGame()
    {
        isGameActive = false;
        isEnd = true;
        StopCoroutine("BackgroundMoving");
    }

    private void ResetGame()
    {
        P1Score = 0;
        P2Score = 0;
        P1ScoreText.text = P1ScoreText.ToString();
        P2ScoreText.text = P2ScoreText.ToString();
        StartGame();
    }

    private IEnumerator BackgroundMoving()
    {
        while (true)
        {
            if (Cloud1.GetComponent<Transform>().localPosition.x < -15.63f)
                Cloud1.GetComponent<Transform>().localPosition = new Vector3(16.37f, -0.6f, 0f);

            Cloud1.GetComponent<Transform>().localPosition += Vector3.left * Clouds_MOVING_SPEED * 0.5f;

            if (Cloud2.GetComponent<Transform>().localPosition.x < -15.63f)
                Cloud2.GetComponent<Transform>().localPosition = new Vector3(16.37f, -0.6f, 0f);

            Cloud2.GetComponent<Transform>().localPosition += Vector3.left * Clouds_MOVING_SPEED * 0.5f;

            yield return new WaitForEndOfFrame();
        }
    }
}

public class GM
{
    private static GameManager _gameManager = null;

    public static GameManager GameManager
    {
        get
        {
            if (_gameManager == null)
                _gameManager = GameObject.FindObjectOfType<GameManager>();
            return _gameManager;
        }
    }
}