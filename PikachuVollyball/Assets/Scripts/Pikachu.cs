using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : MonoBehaviour
{
    public GameObject Pikachu_Left;
    public GameObject Pikachu_Right;
    private static Vector2 JumpVector = new Vector2(0, 18f);
    public float Pikachu_LeftX;
    public float Pikachu_LeftY;
    public float Pikachu_RightX;
    public float Pikachu_RightY;

    public AudioSource Pika_L;
    public AudioSource Pika_R;

    public bool LeftPikachuJumping = false;
    public bool RightPikachuJumping = false;

    private void Start()
    {
        Update();
    }

    public void P1RightMoving()
    {
        Pikachu_Left.GetComponent<Transform>().localPosition += Vector3.right * 0.1f;
    }

    public void P1LeftMoving()
    {
        Pikachu_Left.GetComponent<Transform>().localPosition += Vector3.left * 0.1f;
    }

    public void P1Jumping()
    {
        Pikachu_Left.GetComponent<Rigidbody2D>().velocity = JumpVector * 0.668f;
        Pika_L.Play();
    }

    public void P2RightMoving()
    {
        Pikachu_Right.GetComponent<Transform>().localPosition += Vector3.right * 0.1f;
    }

    public void P2LeftMoving()
    {
        Pikachu_Right.GetComponent<Transform>().localPosition += Vector3.left * 0.1f;
    }

    public void P2Jumping()
    {
        Pikachu_Right.GetComponent<Rigidbody2D>().velocity = JumpVector * 0.668f;
        Pika_R.Play();
    }

    private void Update()
    {
        Pikachu_LeftX = Pikachu_Left.GetComponent<Transform>().localPosition.x;
        Pikachu_LeftY = Pikachu_Left.GetComponent<Transform>().localPosition.y;
        Pikachu_RightX = Pikachu_Right.GetComponent<Transform>().localPosition.x;
        Pikachu_RightY = Pikachu_Right.GetComponent<Transform>().localPosition.y;
        Pikachu_Left.GetComponent<Rigidbody2D>().freezeRotation = true;
        Pikachu_Right.GetComponent<Rigidbody2D>().freezeRotation = true;

        if (Input.GetKey(KeyCode.W) && !LeftPikachuJumping)
        {
            LeftPikachuJumping = true;
            P1Jumping();
        }
        if (Pikachu_LeftY < -2.8 && LeftPikachuJumping)
            LeftPikachuJumping = false;

        if (Input.GetKey(KeyCode.A) && Pikachu_LeftX > -5.8f)
            P1LeftMoving();

        if (Input.GetKey(KeyCode.D) && Pikachu_LeftX < -1f)
            P1RightMoving();

        if (Input.GetKey(KeyCode.UpArrow) && !RightPikachuJumping)
        {
            RightPikachuJumping = true;
            P2Jumping();
        }
        if (Pikachu_RightY < -2.8 && RightPikachuJumping)
            RightPikachuJumping = false;

        if (Input.GetKey(KeyCode.LeftArrow) && Pikachu_RightX > 1.2f)
            P2LeftMoving();

        if (Input.GetKey(KeyCode.RightArrow) && Pikachu_RightX < 5.8f)
            P2RightMoving();

        if (Pikachu_LeftX < -5.8f)
            Pikachu_Left.GetComponent<Transform>().localPosition = new Vector3(-5.8f, Pikachu_LeftY, Pikachu_Left.GetComponent<Transform>().localPosition.z);
        else if (Pikachu_LeftX > -1f)
            Pikachu_Left.GetComponent<Transform>().localPosition = new Vector3(-1f, Pikachu_LeftY, Pikachu_Left.GetComponent<Transform>().localPosition.z);

        if (Pikachu_RightX > 5.8f)
            Pikachu_Right.GetComponent<Transform>().localPosition = new Vector3(5.8f, Pikachu_RightY, Pikachu_Right.GetComponent<Transform>().localPosition.z);
        else if (Pikachu_RightX < 1.2f)
            Pikachu_Right.GetComponent<Transform>().localPosition = new Vector3(1.2f, Pikachu_RightY, Pikachu_Right.GetComponent<Transform>().localPosition.z);
    }
}

public class Pika
{
    private static Pikachu _pikachu = null;

    public static Pikachu Pikachu
    {
        get
        {
            if (_pikachu == null)
                _pikachu = GameObject.FindObjectOfType<Pikachu>();
            return _pikachu;
        }
    }
}