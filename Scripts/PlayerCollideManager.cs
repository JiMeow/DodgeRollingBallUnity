using UnityEngine;

public class PlayerCollideManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerMovement.ResetJump();
            Debug.Log("Player hit obstacle");
        }
    }
}
