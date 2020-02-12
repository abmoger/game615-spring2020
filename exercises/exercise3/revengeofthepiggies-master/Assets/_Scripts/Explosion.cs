using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public GameObject explosion;
    const int EXPLOSION_TIME = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Invoke("ExplosionDestroy", EXPLOSION_TIME);
        }
        
    }
    
    private void ExplosionDestroy()
    {
        //Neither of these lines work to destory the explostion after it is instantiated, not sure why
        //explosion.SetActive(false);
        Destroy(explosion);
    }
}
