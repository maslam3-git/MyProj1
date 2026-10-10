
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private GameObject gameOverPanel;

    private int score;
    private int health = 3;
    private int highScore;

    public bool IsGameOver { get; private set; }

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("SpaceHighScore", 0);
        score = 0;
        health = 3;
        IsGameOver = false;

        gameOverPanel.SetActive(false);
        UpdateUI();
    }

    public void AddScore(int points)
    {
        if (IsGameOver)
            return;

        score += points;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("SpaceHighScore", highScore);
            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        if (IsGameOver)
            return;

        health -= amount;

        if (health <= 0)
        {
            health = 0;
            GameOver();
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health;
        highScoreText.text = "Best: " + highScore;
    }

    private void GameOver()
    {
        IsGameOver = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnDestroy()
    {
        Time.timeScale = 1f;
    }
}
