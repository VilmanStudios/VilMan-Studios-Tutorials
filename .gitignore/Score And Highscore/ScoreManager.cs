using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score;
    public int highscore;

    public TextMeshProUGUI score_text;
    public TextMeshProUGUI highscore_text;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
        }

        score_text.text = score.ToString();
        highscore_text.text = highscore.ToString();
    }

    public void AddScore()
    {
        score += 1;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
