using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;

    public Transform topPipe;
    public Transform bottomPipe;

    public float minTopY = 2.5f;
    public float maxTopY = 5.5f;

    public float gap = 9f;

    // Xóa pipe khi qua màn hình
    public float destroyPoint = -13f;

    void Start()
    {
        RandomPipe();
    }

    void Update()
    {
        // Di chuyển sang trái
        transform.position +=
            Vector3.left * speed * Time.deltaTime;

        // Xóa pipe
        if (transform.position.x <= destroyPoint)
        {
            Destroy(gameObject);
        }
    }

    void RandomPipe()
    {
        // Random Y cho pipe trên
        float topY =
            Random.Range(minTopY, maxTopY);

        // Pipe trên
        topPipe.localPosition =
            new Vector3(0, topY, 0);

        // Pipe dưới
        bottomPipe.localPosition =
            new Vector3(0, topY - gap, 0);
    }
}