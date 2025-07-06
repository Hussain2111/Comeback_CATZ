using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BallUIController : MonoBehaviour
{
    public RectTransform goalPosition;

    public void MoveBall()
    {
        // Move the ball to the goal position
        transform.position = goalPosition.position;
        Debug.Log("Ball moved!");
    }
}
