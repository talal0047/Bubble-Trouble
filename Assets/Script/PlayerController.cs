using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D player;

    private float direction = 0f;
    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal") * speed; // unity own input function gives a value from -1 to 1. if 0 then user haven't pressed any button
        // if 1 then user have pressed 'D' or 'Right key'
        // if -1 then user have pressed 'A' or 'Left key'
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + new Vector2(direction * Time.fixedDeltaTime, 0));
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("going Lose");

        if (other.gameObject.CompareTag("Circle"))
        {
            Debug.Log("Lose");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
