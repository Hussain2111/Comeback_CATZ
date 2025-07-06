using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 10f;
    public TextMeshProUGUI timerText;
    public GameObject gameOverScreen;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timeRemaining).ToString();
        }
        else
        {
            timeRemaining = 0;
            timerText.text = "0";
            gameOverScreen.SetActive(true); // Show a panel or something that says "Time's Up!"
            // Optional: Disable buttons or freeze game
        }
    }
}
