using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCamera : MonoBehaviour
{
    //variavel de tempo
    private int time = 0;
    
    //variavel de resetar camera
    private int timeReset = 0;
    
    //inverte camera
    [SerializeField] private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //se tempo igual a 20 inverte camera por 10 segundos
        if (time == 20)
        {
            time = 0;
            camera.transform.Rotate(0, 0, -180);
        }
        //inverte a camera de volta ao normal
        if (timeReset == 30)
        {
            timeReset = 0;
            camera.transform.Rotate(0, 0, 180);
        }
    }
    
    
    private void Timer()
    {
        time += 1;
        timeReset += 1;
    }
}
