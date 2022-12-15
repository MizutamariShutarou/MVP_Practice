using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using Unity.VisualScripting;

public class UIModel
{
    private float _scoreValue;
    private float _timeValue;

    public float ScoreValue
    {
        get { return _scoreValue; }
        set
        {
            _scoreValue = value;
            OnSetScore?.Invoke(_scoreValue);
        }
    }

    public float TimeValue
    {
        get { return _timeValue; }
        set
        {
            _timeValue = value;
            OnSetTime?.Invoke(_timeValue);
        }
    }

    public event Action<float> OnSetScore;
    public event Action<float> OnSetTime;

    public UIModel()
    {
        ScoreValue = 0;
        TimeValue = 0;
    }

    public void AddScore()
    {
        ScoreValue += 100;
    }

    public void AddTime()
    {
        TimeValue += Time.deltaTime;
    }

    public void ResetUI()
    {
        ScoreValue = 0;
    }
}