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

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        sr.sprite = idleSprite;

        gameOverUI.SetActive(false);
    }

    void Update(){
        if (isDead) return;

        if (Keyboard.current.spaceKey.wasPressedThisFrame){
            rb.linearVelocity = Vector2.up * jumpForce;
            sr.sprite = flapSprite;

            Invoke(nameof(ResetSprite), 0.2f);
        }
    }

    private void ResetSprite(){
        sr.sprite = idleSprite;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("Ground")){
            GameOver();
        }
    }

    private void GameOver(){
        isDead = true;
        
        // hien game over UI
        gameOverUI.SetActive(true);

        // dung game
        Time.timeScale = 0f;
    }
}
