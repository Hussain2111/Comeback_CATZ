using UnityEngine;
using TMPro;

public class BallUIController : MonoBehaviour
{
    public RectTransform kickoffPosition;  // assign this in Unity
    public RectTransform topGoal;
    public RectTransform bottomGoal;
    //public TMP_Text feedbackText;
    public TMP_Text Score;
    public float moveSpeed = 1500f;  // This is pixels/sec — scale for Canvas UI

    private Vector3 targetPos;
    private bool isMoving = false;
    private System.Action onReachTarget = null;
    private bool inputLocked = false;

    public int playerScore = 0;
    public int opponentScore = 0;

    public void HandleCorrectAnswer(Transform buttonTransform)
    {
        if (inputLocked) return;
        inputLocked = true;

        //feedbackText.text = "Yeah!";

        MoveBallTo(buttonTransform.position, () =>
        {
            playerScore++;
            UpdateScoreboard();
            MoveBallTo(topGoal.position, () =>
            {
                ResetPlay();
            });
        });
    }

    public void HandleWrongAnswer(Transform buttonTransform)
    {
        if (inputLocked) return;
        inputLocked = true;

        //feedbackText.text = "Are you sure?";

        MoveBallTo(buttonTransform.position, () =>
        {
            opponentScore++;
            UpdateScoreboard();
            MoveBallTo(bottomGoal.position, () =>
            {
                ResetPlay();
            });
        });
    }

    void ResetPlay()
    {
        MoveBallTo(kickoffPosition.position);
        inputLocked = false;
        //feedbackText.text = "";
    }



    public void MoveBallTo(Vector3 destination, System.Action callback = null)
    {
        targetPos = destination;
        isMoving = true;
        onReachTarget = callback;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPos) < 0.5f)
            {
                transform.position = targetPos;
                isMoving = false;

                if (onReachTarget != null)
                {
                    var action = onReachTarget;
                    onReachTarget = null;
                    action.Invoke();
                }
            }
        }
    }

    void UpdateScoreboard()
    {
        Score.text = playerScore + " - " + opponentScore; 
    }
}
