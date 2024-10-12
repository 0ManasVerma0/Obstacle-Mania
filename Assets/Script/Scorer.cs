using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            Hits++;
            Debug.Log("You have bumped into the wall this many times:" + Hits);
        }
        
    }
}
