using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panda : MonoBehaviour
{
    float horizontal;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
        }

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * -10f, rb.velocity.y);
    }


    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Plans")
        { 
        rb.velocity = Vector2.zero;
        rb.AddForce(transform.up * 5, ForceMode.Impulse);
        }
        if (other.gameObject.tag == "Wall")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.position * 2 , ForceMode.Impulse);
        }

    }
}
