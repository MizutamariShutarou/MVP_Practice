using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    [SerializeField] 
    private Text _timeText;

    public void Initialize()
    {
        gameObject.SetActive(true);
        _scoreText.text = "0";
    }
    public void SetScore(float score)
    {
        _scoreText.text = score.ToString();
    }

    public void SetTime(float time)
    {
        _timeText.text = time.ToString("F1");
    }
}
