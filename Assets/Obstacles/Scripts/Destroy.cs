using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //função que destrói o objeto
    public void DestroyObstacle()
    {
        //destroi obstaculo
        Destroy(obstacle);
    }
}
