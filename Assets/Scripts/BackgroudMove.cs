using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float speed = 2f;

    // vị trí reset
    public float resetPosition = -23f;

    // vi tri nhay den
    public float startPosition = 23f;

    void Update()
    {
        // di chuyển background
        transform.position += Vector3.left * speed * Time.deltaTime;

        // nếu background đi qua vị trí reset thì reset về vị trí bắt đầu
        if (transform.position.x <= resetPosition)
        {
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}
