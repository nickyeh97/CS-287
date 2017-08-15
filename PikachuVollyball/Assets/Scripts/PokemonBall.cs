using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBall : MonoBehaviour
{
    private float LeftPikaX = GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.x;
    private float LeftPikaY = GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.y;
    private float RightPikaX = GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.x;
    private float RightPikaY = GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.y;
    private float BallX = GM.GameManager.Pokemonball.GetComponent<Transform>().localPosition.x;
    private float BallY = GM.GameManager.Pokemonball.GetComponent<Transform>().localPosition.y;
    private static Vector2 BallVector = new Vector2(0, -1);

    public void P1TouchTheBall()
    {
        //左皮卡碰球
        double x = BallX - LeftPikaX;
        double y = BallY - LeftPikaY;
        double ball_vector_length = Math.Sqrt((int)BallVector[0] ^ 2 + (int)BallVector[1] ^ 2);
        double diff_vector_length = Math.Sqrt((int)x ^ 2 + (int)y ^ 2);
        double ratio = ball_vector_length / diff_vector_length;

        BallVector.x = (float)x * (float)ratio;
        BallVector.y = (float)y * (float)ratio;
    }
}