using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBall : MonoBehaviour
{
    public GameObject Pokemonball;
    public AudioSource OnGround;
    public float BallX = 0;
    public float BallY = 0;
    public float BallZ = 0;
    public float Ratio;
    public bool BallCollisionToPika = false;
    public bool BallCollisionToGround = false;
    public Vector2 BallVector = new Vector2(0, -1);
    public Vector2 DirectionVector;

    private void Start()
    {
        Update();
        Pokemonball.GetComponent<Rigidbody2D>().velocity = BallVector;
    }

    public void TouchTheBall()
    {
        BallX = Pokemonball.GetComponent<Transform>().localPosition.x;
        BallY = Pokemonball.GetComponent<Transform>().localPosition.y;

        /*
        Debug.Log(BallX);
        Debug.Log(BallY);
        Debug.Log(Pika.Pikachu.Pikachu_LeftX);
        Debug.Log(Pika.Pikachu.Pikachu_LeftY);
        Debug.Log(BallVector);
        */
        //左皮卡碰球
        float x = BallX - Pika.Pikachu.Pikachu_Left.GetComponent<Transform>().localPosition.x;
        float y = BallY - Pika.Pikachu.Pikachu_Left.GetComponent<Transform>().localPosition.y;
        float ball_vector_length = (float)Math.Sqrt(BallVector[0] * BallVector[0] + BallVector[1] * BallVector[1]);
        float diff_vector_length = (float)Math.Sqrt(x * x + y * y);
        Vector2 directionVector = new Vector2(x, y);
        if (diff_vector_length == 0)
            diff_vector_length = 1;
        float ratio = ball_vector_length / diff_vector_length;

        //右皮卡碰球
        float x2 = BallX - Pika.Pikachu.Pikachu_RightX;
        float y2 = BallY - Pika.Pikachu.Pikachu_RightY;
        float ball_vector_length2 = (float)Math.Sqrt(BallVector[0] * BallVector[0] + BallVector[1] * BallVector[1]);
        float diff_vector_length2 = (float)Math.Sqrt(x2 * x2 + y2 * y2);
        Vector2 directionVector2 = new Vector2(x2, y2);
        if (diff_vector_length2 == 0)
            diff_vector_length2 = 1;
        float ratio2 = ball_vector_length2 / diff_vector_length2;

        Ratio = BallX <= 0 ? ratio : ratio2;
        DirectionVector = BallX <= 0 ? directionVector : directionVector2;

        BallVector = DirectionVector * Ratio;
        Pokemonball.GetComponent<Rigidbody2D>().AddForce(BallVector * 15);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            BallCollisionToPika = true;
        }
        else if (col.gameObject.CompareTag("ground"))
        {
            BallCollisionToGround = true;
            OnGround.Play();
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            BallVector.y *= -0.8f;
            Pokemonball.GetComponent<Rigidbody2D>().velocity = BallVector;
        }
    }

    private IEnumerator reseting()
    {
        yield return new WaitForSeconds(1);
        Pokemonball.GetComponent<Transform>().localPosition = new Vector3(-5.5f, 3.76f, 0);
        Pika.Pikachu.Pikachu_Left.GetComponent<Transform>().localPosition = new Vector3(-5.5f, -3f, 0);
        Pika.Pikachu.Pikachu_Right.GetComponent<Transform>().localPosition = new Vector3(5.5f, -3f, 0);
    }

    private void Update()
    {
        Pokemonball.GetComponent<Rigidbody2D>().gravityScale = 0;
        if (GM.GameManager.isGameActive)
        {
            Pokemonball.GetComponent<Rigidbody2D>().gravityScale = 1;

            BallX = Pokemonball.GetComponent<Transform>().localPosition.x;
            BallY = Pokemonball.GetComponent<Transform>().localPosition.y;
            BallZ = Pokemonball.GetComponent<Transform>().localPosition.z;

            Pokemonball.GetComponent<Rigidbody2D>().freezeRotation = true;

            if (BallCollisionToPika)
            {
                TouchTheBall();
                BallCollisionToPika = false;
            }
            if (BallCollisionToGround)
            {
                Pokemonball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                BallCollisionToGround = false;
                StartCoroutine("reseting");

                if (Pokemonball.GetComponent<Transform>().localPosition.x > 0)
                {
                    GM.GameManager.P1Score++;
                    GM.GameManager.P1ScoreText.text = GM.GameManager.P1Score.ToString();
                }
                else
                {
                    GM.GameManager.P2Score++;
                    GM.GameManager.P2ScoreText.text = GM.GameManager.P2Score.ToString();
                }
            }
            //TouchOnScreen()
            if (BallY > 4.4)
            {
                BallVector.y *= -0.8f;
                //避免卡牆
                Pokemonball.GetComponent<Transform>().localPosition = new Vector3(BallX, 4.4f, BallZ);
                Pokemonball.GetComponent<Rigidbody2D>().velocity = BallVector;
            }
            else if (BallX > 5.9)
            {
                BallVector.x *= -0.8f;
                //避免卡牆
                Pokemonball.GetComponent<Transform>().localPosition = new Vector3(5.9f, BallY, BallZ);
                Pokemonball.GetComponent<Rigidbody2D>().velocity = BallVector;
            }
            else if (BallX < -5.9)
            {
                BallVector.x *= -0.8f;
                //避免卡牆
                Pokemonball.GetComponent<Transform>().localPosition = new Vector3(-5.9f, BallY, BallZ);
                Pokemonball.GetComponent<Rigidbody2D>().velocity = BallVector;
            }

            //球速度 更新
            BallVector = Pokemonball.GetComponent<Rigidbody2D>().velocity;
        }
    }
}