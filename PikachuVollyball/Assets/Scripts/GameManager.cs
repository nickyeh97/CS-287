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
    public GameObject Clouds;

    public GameObject PikachuLeft;
    public GameObject PikachuRight;
    public GameObject Pokemonball;
    /*
    public Text P1ScoreText;
    public Text P2ScoreText;

    public bool isGameActive = false;
    public bool isPrepare = false;
    */

    #endregion Inspecter Variables

    [HideInInspector]
    private static float MOVING_SPEED = 10; // 移動速度

    private static float Clouds_MOVING_SPEED = .05f;

    private static Vector2 JumpVector = new Vector2(0, 18f);
    private static Vector2 LeftVector = new Vector2(3f, 0);
    private static Vector2 RightVector = new Vector2(3f, 0);
    public bool LeftPikachuJumping = false;
    public bool RightPikachuJumping = false;

    private void Start()
    {
        //PrePareView();
        StartCoroutine("BackgroundMoving");
        Update();
    }

    private void PrePareView()
    {
        HomeGroup.SetActive(true);
        StartCoroutine("BackgroundMoving");
        //isPrepare = true;
    }

    public void StartGame()
    {
        // isGameActive = true;
        // isPrepare = false;
        HomeGroup.SetActive(false);
    }

    public void EndGame()
    {
        // isGameActive = false;
        StopCoroutine("BackgroundMoving");
    }

    private void ResetGame()
    {
        //GamePoint = 0;
        //PointText.text = GamePoint.ToString();
        HomeGroup.SetActive(false);
        //ResultGroup.SetActive(false);
    }

    private IEnumerator BackgroundMoving()
    {
        while (true)
        {
            if (Clouds.GetComponent<Transform>().localPosition.x < -15.63f)
                Clouds.GetComponent<Transform>().localPosition = new Vector3(16.37f, -0.6f, 0f);

            Clouds.GetComponent<Transform>().localPosition += Vector3.left * Clouds_MOVING_SPEED * 0.5f;

            yield return new WaitForEndOfFrame();
        }
    }

    public void P2TouchTheBall()
    {
        // isGameActive = false;
        StopCoroutine("BackgroundMoving");
    }

    // Update is called once per frame
    private void Update()
    {
        //Pikachu pikachu = new Pikachu();

        if (Input.GetKey(KeyCode.W) && !LeftPikachuJumping)
        {
            LeftPikachuJumping = true;
            PikachuLeft.GetComponent<Rigidbody2D>().velocity = JumpVector * 0.668f;
        }
        if (GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.y < -2.8 && LeftPikachuJumping)
            LeftPikachuJumping = false;
        if (Input.GetKey(KeyCode.A) && GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.x > -5.8f)
            PikachuLeft.GetComponent<Transform>().localPosition += Vector3.left * 0.1f;
        if (Input.GetKey(KeyCode.D) && GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.x < -1f)
            PikachuLeft.GetComponent<Transform>().localPosition += Vector3.right * 0.1f;

        if (Input.GetKey(KeyCode.UpArrow) && !RightPikachuJumping)
        {
            RightPikachuJumping = true;
            PikachuRight.GetComponent<Rigidbody2D>().velocity = JumpVector * 0.668f;
        }
        if (GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.y < -2.8 && RightPikachuJumping)
            RightPikachuJumping = false;
        if (Input.GetKey(KeyCode.LeftArrow) && GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.x > 1.2f)
            PikachuRight.GetComponent<Transform>().localPosition += Vector3.left * 0.1f;
        if (Input.GetKey(KeyCode.RightArrow) && GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.x < 5.8f)
            PikachuRight.GetComponent<Transform>().localPosition += Vector3.right * 0.1f;
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