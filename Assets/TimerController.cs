using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timer_text;
    [SerializeField] float remainingTime = 10f;
    public GameObject gameOverPanel;
    public TMP_Text resultText;


    [SerializeField] BallUIController ball; // Drag it in from Inspector
    [SerializeField] RectTransform bottomGoal;

    private bool hasTriggered = false;

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (!hasTriggered)
        {
            remainingTime = 0;
            hasTriggered = true;

            // Send to bottom goal
            //ball.feedbackText.text = "Too slow!";
            ball.MoveBallTo(bottomGoal.position);
            ShowGameOver();
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer_text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void ShowGameOver()
    {
        gameOverPanel.SetActive(true);

        if (ball.playerScore > ball.opponentScore)
            resultText.text = "You Win!";
        else if (ball.playerScore < ball.opponentScore)
            resultText.text = "You Lose!";
        else
            resultText.text = "Draw!";
    }

}
