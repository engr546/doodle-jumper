using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().GameOver();    
        }
    }

}
