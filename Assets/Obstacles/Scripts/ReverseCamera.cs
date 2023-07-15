using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCamera : MonoBehaviour
{
    //variavel de tempo
    private int time = 0;

    //variavel randomizada
    private int randomTime = 0;

    //inverte camera
    [SerializeField] private GameObject camera;
    
    //inverte interface
    [SerializeField] private GameObject inter;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //randomiza tempo
        randomTime = Random.Range(5, 20);
        
        //se tempo igual ao tempo randomizado
        if (time == randomTime)
        {
            time = 0;
            camera.transform.Rotate(0, 0, -180);
            inter.transform.Rotate(0, 0, -180);
        }
    }
    
    
    private void Timer()
    {
        time += 1;
    }
}
