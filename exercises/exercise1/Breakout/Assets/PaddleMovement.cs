using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float paddleSpeed = 0.1f;
    public float paddleX;
    public float paddleY;
    public KeyCode leftKey;
    public KeyCode rightKey;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(leftKey) && transform.position.x > -7.25f)
        {
            transform.position = new Vector3(transform.position.x - paddleSpeed, transform.position.y, 0);
        }
        if (Input.GetKey(rightKey) && transform.position.x < 7.25f)
        {
            transform.position = new Vector3(transform.position.x + paddleSpeed, transform.position.y, 0);
        }
    }
}
