using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public KeyCode launchButton;
    public float ballVelocity = 75f;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
      if (Input.GetKey(launchButton))
        {
            transform.parent = null;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, ballVelocity, 0));
        }  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BottomWall")
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
