using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider2D groundCollider;
    float groundHorizontalLength;
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }
    void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength*2f, 0);
        transform.position = (Vector2)transform.position + groundOffset; 
    }
}
