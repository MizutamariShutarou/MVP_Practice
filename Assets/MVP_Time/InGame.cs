using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour
{
    [SerializeField]
    ScorePresenter _score;
    void Start()
    {
        _score.Initialize();
    }
    void Update()
    {
        _score.AddScore();
        _score.ResetScore();
    }

}

    