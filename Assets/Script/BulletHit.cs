using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
    {
        Bullet.fireStatus = false;

        if(other.tag == "Circle")
        {
            other.GetComponent<BallController>().split();
        }
    }
}
