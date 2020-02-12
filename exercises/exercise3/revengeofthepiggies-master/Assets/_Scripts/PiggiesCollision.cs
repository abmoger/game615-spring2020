using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggiesCollision : MonoBehaviour
{
    public ScoreManager ScoreManager;
    const int TIME_TO_RESET = 5;
    Vector3 originalPosition;
    Transform parent;

    private void Start()
    {
        originalPosition = transform.localPosition;
        parent = transform.parent;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("ResetPiggy", TIME_TO_RESET);
        
        if (collision.gameObject.tag != "Floor")
        {
            ScoreManager.PiggyOnStructure();
            Debug.Log("Current Score" + ScoreManager.getScore());
        }
    }

    void ResetPiggy()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        transform.parent = parent;
        transform.localPosition = originalPosition;
        Camera.main.GetComponent<CameraFollow>().resetCameraPosition();
    }
}
