using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text Tmptext;
    private int score;


    public void GiveScore(float _score) 
    {
        score += (int)_score;
        Tmptext.text = score.ToString();
    }
    public void ResetScore() 
    {
        score = 0;
    }
}
