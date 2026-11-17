

using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject trapWarning;

    private void Start()
    {
        trapWarning.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.health -= 10;
                playerHealth.health =
                    Mathf.Max(playerHealth.health, 0);
            }

            trapWarning.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trapWarning.SetActive(false);
        }
    }
}
 