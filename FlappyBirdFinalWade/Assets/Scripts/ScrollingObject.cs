using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);             
   
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver == true)
        {
            rigidbody2d.velocity = Vector2.zero;
        }
    }
}
