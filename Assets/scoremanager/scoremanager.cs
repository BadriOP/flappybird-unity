using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int score = 0;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}