using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static bool fireStatus = false;
    public float speed = 1f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        fireStatus = false; // when a scene change to force to to seize fire
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireStatus = true;
        }

        if (fireStatus)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed; ;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector2(1f, 0f);
        }
    }
}
