using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 7f;

    public GameManager gameManager;
    public ScoreManager scoreManager;

    bool gameStarted = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Bird jump on screen touch or mouse click
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            gameStarted = true;
        }
    }

    // Detect collision with pipe or ground → Game Over
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameStarted)
        {
            gameManager.GameOver();
        }
    }

    // Detect passing through score zone → increase score
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("scorezone"))
        {
            scoreManager.AddScore();
        }
    }
}