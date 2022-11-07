using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePresenter : MonoBehaviour
{
    private ScoreModel _model;
    [SerializeField] ScoreView _view;

    public void Initialize()
    {
        _model = new ScoreModel();
        _view.Initialize();

        Bind();
    }

    private void Bind()
    {
        _model.OnSetScore += _view.SetScore;
    }

    public void AddScore()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _model.AddScore();
        }
    }

    public void ResetScore()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _model.ResetScore();
        }
    }


}
