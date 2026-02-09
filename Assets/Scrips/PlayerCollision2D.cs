using UnityEngine;

public class PlayerCollision2D : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ON COLLISION với: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ON TRIGGER với: " + other.gameObject.name);
    }
}
