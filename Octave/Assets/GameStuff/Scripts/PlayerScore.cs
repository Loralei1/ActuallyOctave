using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour

{
    private int scorenum;
    public Text ScoreText;

    private void Start()
    {
        scorenum = 0; 
        SetScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (tag)
        {
            case ("QuarterNote"):
                scorenum = scorenum + 1;
                SetScoreText();
                    break; 
            case ("HalfNote"):
                scorenum = scorenum + 2; 
                SetScoreText();
                    break; 
                    
        }
    }
    
    void SetScoreText()
    {
        ScoreText.text = "Score: " + scorenum.ToString();
    }
}
