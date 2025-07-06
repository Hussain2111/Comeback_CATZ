public class BallMover : MonoBehaviour
{
    public Transform targetPosition;

    public void PassBall()
    {
        transform.position = targetPosition.position;
    }
}
