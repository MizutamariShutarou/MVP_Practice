using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InGame : MonoBehaviour
{ 
    [SerializeField]
    UIPresenter _uiPresenter;
    void Start()
    {
        _uiPresenter.Initialize();
    }
    void Update()
    {
        _uiPresenter.AddScore();
        _uiPresenter.ResetScore();
        _uiPresenter.TimeCounter();
    }

}

    