using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMaker : MonoBehaviour
{
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointMakerPlayer()
    {
        points += 1;
        Debug.Log(points);
    }
}
