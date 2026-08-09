using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6f;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}