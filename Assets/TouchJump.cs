using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchJump : MonoBehaviour
{
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private float jumpForce = 600f;
    
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(8).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
        }
    }
}