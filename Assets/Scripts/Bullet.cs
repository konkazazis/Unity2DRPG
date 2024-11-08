using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Move the bullet upwards every frame
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Destroy the bullet if it goes off the screen
        if (transform.position.y > 5.5f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
