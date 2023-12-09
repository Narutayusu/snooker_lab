using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playScore;
    public int PlayScore 
    { 
        get { return playScore; } 
        set { playScore = value; }
    }
 
    [SerializeField]
    private GameObject ballPrefab;
 
    [SerializeField]
    private GameObject[] ballPositions;

    public static GameManager Instance;
 
    void Start()
    {
        Instance = this;
       
        SetBall(BallColors.Red,    1);
        SetBall(BallColors.Yellow, 2);
        SetBall(BallColors.Green,  3);
        SetBall(BallColors.Brown,  4);
        SetBall(BallColors.Blue,   5);
        SetBall(BallColors.Pink,   6);
        SetBall(BallColors.Black,  7);
        
    }

    private void Update()
    {
      
    }

    private void SetBall(BallColors col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
                         ballPositions[i].transform.position,
                         Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }

    
}