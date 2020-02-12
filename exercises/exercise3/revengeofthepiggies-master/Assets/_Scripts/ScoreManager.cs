using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    const int STRUCTURE_HIT_POINT = 1;
    const int PIGGY_HIT_STRUCTURE_POINT = 5;
    int score = 0;

    public int getScore()
    {
        return score;
    }

    public void StructureOnStructure()
    {
        score = score + STRUCTURE_HIT_POINT;
    }

    public void PiggyOnStructure()
    {
        score = score + PIGGY_HIT_STRUCTURE_POINT;
    }
}
