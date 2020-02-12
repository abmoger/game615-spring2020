using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureCollision : MonoBehaviour
{
    public ScoreManager ScoreManager;
    public GameObject Piggy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block" && Piggy.transform.parent == null)
        {
          ScoreManager.StructureOnStructure();
          Debug.Log("Current Score" + ScoreManager.getScore());
        }
    }
}
