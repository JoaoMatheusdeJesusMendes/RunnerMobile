using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //se colidir com obstaculo despawna ele 
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 8)
        {
            //destroi o objeto   
            DestroyObstacle(other.gameObject);
        }
    }
    
    //função que destrói o objeto
    public void DestroyObstacle(GameObject obst)
    {
        //destroi obstaculo
        Destroy(obst);
    }
}
