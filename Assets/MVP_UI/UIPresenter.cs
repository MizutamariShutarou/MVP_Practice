using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPresenter : MonoBehaviour
{
    private UIModel _model;
    [SerializeField] UIView _view;

    public void Initialize()
    {
        _model = new UIModel();
        _view.Initialize();

        Bind();
    }

    private void Bind()
    {
        _model.OnSetScore += _view.SetScore;
        _model.OnSetTime += _view.SetTime;
    }

    public void AddScore()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _model.AddScore();
        }
    }

    public void TimeCounter()
    {
        _model.AddTime();
    }

    public void ResetScore()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            _model.ResetUI();
        }
    }


}
