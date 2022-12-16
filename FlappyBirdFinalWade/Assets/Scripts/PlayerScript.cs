using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    float horizontal;
    float vertical;
    public float upforce = 40.0f;
    Rigidbody2D rigidbody2d;
    bool stillAlive = true;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stillAlive == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2d.velocity = Vector2.zero;
                rigidbody2d.AddForce(new Vector2(0, upforce));
            }
        }
        
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody2d.velocity = Vector2.zero;

        stillAlive = false;
        Destroy(gameObject);
    }


}
