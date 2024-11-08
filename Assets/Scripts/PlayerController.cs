using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Controls how fast the player moves
    public GameObject bulletPrefab; // Prefab for the bullet
    public Transform bulletSpawnPoint; // Position where the bullet spawns

    void Update()
    {
        // Player movement
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

        // Restrict player to screen bounds
        float xPos = Mathf.Clamp(transform.position.x, -7.5f, 7.5f);
        transform.position = new Vector3(xPos, transform.position.y, 0);

        // Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}
