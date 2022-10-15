using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player
    [SerializeField] private float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 moveImput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveImput = new Vector2(moveX, moveY);
    }
    // Fix Phisics
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveImput * moveSpeed * Time.fixedDeltaTime);

        //moves character with arrows
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(moveSpeed, 0, 0);
        }
    }
}