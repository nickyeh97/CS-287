using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public float X;
    public float Y;
}

public class Pikachu : MonoBehaviour
{
    public bool LeftPikachuJumping = false;
    public bool RightPikachuJumping = false;
    /*
    public List<Player> Players;

    public Pikachu()
    {
        Players = new List<Player>();
        Players.Add(new Player()
        {
            X = GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.x,
            Y = GM.GameManager.PikachuLeft.GetComponent<Transform>().localPosition.y
        });
        Players.Add(new Player()
        {
            X = GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.x,
            Y = GM.GameManager.PikachuRight.GetComponent<Transform>().localPosition.y
        });*/
}