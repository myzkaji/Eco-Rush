using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private int lives = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            lives--;

            Debug.Log("ECHO got hit! Lives left: " + lives);

            Destroy(collision.gameObject);

            if (lives <= 0)
            {
                Debug.Log("GAME OVER!");
            }
        }
    }
}