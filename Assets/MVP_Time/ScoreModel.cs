using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ScoreModel
{
    private float _scoreValue;
    private float ScoreValue
    {
        get { return _scoreValue; }
        set { _scoreValue = value; OnSetScore?.Invoke(_scoreValue); }
    }

    public event Action<float> OnSetScore; 

    public ScoreModel()
    {
        ScoreValue = 0;
    }

    public void AddScore()
    {
        ScoreValue += 100;
    }

    public void ResetScore()
    {
        ScoreValue = 0;
    }
}
