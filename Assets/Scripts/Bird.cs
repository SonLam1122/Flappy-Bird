using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    public float jumpForce = 5f;

    public Sprite idleSprite;
    public Sprite flapSprite;

    public GameObject gameOverUI;

    private bool isDead = false;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        sr.sprite = idleSprite;

        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if (isDead) return;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * jumpForce;

            sr.sprite = flapSprite;

            Invoke(nameof(ResetSprite), 0.15f);
        }
    }

    void ResetSprite()
    {
        sr.sprite = idleSprite;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Nếu chạm Ground hoặc Pipe
        if (collision.gameObject.CompareTag("Ground")
            || collision.gameObject.CompareTag("Pipe"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isDead = true;

        // Hiện UI Game Over
        gameOverUI.SetActive(true);

        // Dừng game
        Time.timeScale = 0f;
    }
}