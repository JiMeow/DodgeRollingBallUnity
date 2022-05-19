using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRb;
    int jumpCount;
    void Start()
    {
        Debug.Log("Start Game");
        playerRb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    void Update()
    {
        Debug.Log(Time.timeScale);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(-5, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(0, 0, -5);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                jumpCount++;
                playerRb.velocity = new Vector3(0, 7, 0);
            }
        }
    }
    public void ResetJump()
    {
        jumpCount = 0;
    }
}
