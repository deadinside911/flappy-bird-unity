using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffect powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with powerup");

        // Destroy the power up after colliding with it
        Destroy(gameObject);

        // Apply the power up
        powerupEffect.Apply(collision.gameObject);
    }
}
