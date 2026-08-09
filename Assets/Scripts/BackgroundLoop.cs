using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float width = 20f;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x <= -width)
        {
            transform.position += Vector3.right * (width * 2f);
        }
    }
}