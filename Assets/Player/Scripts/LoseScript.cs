using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    [SerializeField] private GameObject Spawn; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        //se colidir com o obstaculo chama a função
        if(other.gameObject.layer == 8 && other.gameObject.layer != 9)
        {
            //desativa scripts após colisão do player
            Spawn.GetComponent<SpawnObstacle>().enabled = false;
            other.GetComponent<MoveObstacle>().enabled = false;
            GetComponent<Moviment>().enabled = false;
            GetComponent<Rigidbody2D>().mass = 0;
        }
    } 
}
