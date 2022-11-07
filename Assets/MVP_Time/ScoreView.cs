using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] Text _scoreText;

    public void Initialize()
    {
        gameObject.SetActive(true);
        _scoreText.text = "0";
    }
    public void SetScore(float score)
    {
        _scoreText.text = score.ToString();
    }
}
