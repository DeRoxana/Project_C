using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue = 0;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }

}
