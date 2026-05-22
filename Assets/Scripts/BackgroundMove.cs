using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float speed = 2f;

    // vị trí sẽ reset
    public float resetPoint = -23.4f;

    // vị trí sẽ nhảy tới
    public float startPoint = 24.5f;

    void Update()
    {
        // di chuyển sang trái
        transform.position += Vector3.left * speed * Time.deltaTime;

        // nếu tới điểm reset
        if (transform.position.x <= resetPoint)
        {
            transform.position = new Vector3(
                startPoint,
                transform.position.y,
                transform.position.z
            );
        }
    }
}