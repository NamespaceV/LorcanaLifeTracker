using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScorePad : MonoBehaviour
{
    [SerializeField] private Button BP1;
    [SerializeField] private Button BP5;
    [SerializeField] private Button BM1;
    [SerializeField] private Button BM5;
    [SerializeField] private TMP_Text ScoreLabel;

    private int score = 0;

    void Start()
    {
        BP1.onClick.AddListener(() => scoreAdd( 1));
        BP5.onClick.AddListener(() => scoreAdd( 5));
        BM1.onClick.AddListener(() => scoreAdd(-1));
        BM5.onClick.AddListener(() => scoreAdd(-5));
    }

    private void scoreAdd(int v)
    {
        score += v;
        ScoreLabel.text = score.ToString();
    }

    void Update()
    {
        
    }
}
