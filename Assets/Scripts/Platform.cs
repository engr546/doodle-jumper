using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    void OnCollisionEnter2D(Collision2D other)
    {
        //if other is comming from above/falling
        if (other.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;            
            }                  
        }
    }

}
