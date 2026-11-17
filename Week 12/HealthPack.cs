using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healthAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {  
        Debug.Log("Health Pack touched!");

        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.health += healthAmount;

                playerHealth.health = Mathf.Min(playerHealth.health, 100);

                Destroy(gameObject);
            }
        }
    }
}