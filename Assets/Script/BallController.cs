using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 startForce;
    public Rigidbody2D ball;
    public GameObject SplitBall;

    // Start is called before the first frame update
    void Start()
    {
        ball.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void split()
    {
        if(SplitBall != null)
        {
           GameObject ball1 = Instantiate(SplitBall,  ball.position + Vector2.right / 4f, Quaternion.identity);
           GameObject ball2 =  Instantiate(SplitBall,  ball.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<BallController>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<BallController>().startForce = new Vector2(-2f, 5f);
        }

        Destroy(gameObject);
    }
}
