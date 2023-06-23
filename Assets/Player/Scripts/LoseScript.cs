using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    [SerializeField] private GameObject Spawn; 
    
    //variavel que recebe o menu de game over
    [SerializeField] private GameObject gameOver;
    
    //variavel que recebe o menu da interface
    [SerializeField] private GameObject interfacePlayer;
    
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
            //desativa interface
            interfacePlayer.SetActive(false);
            //ativa menu de game over
            gameOver.SetActive(true);
        }
        
        //se colidir com o obstaculo bone e o player se mover
        else if (other.gameObject.layer == 9)
        {
            //mudar depois para mobile //////////////////////////
            //Touch touch = Input.GetTouch(0);
            //se o player segurar a tela do celular ele agacha
            //if (touch.phase == TouchPhase.Stationary || Input.GetKeyDown(KeyCode.S))
            if (GetComponent<Rigidbody2D>().velocity.y >= 1 || GetComponent<Rigidbody2D>().velocity.y <= -1 || Input.GetKey(KeyCode.S))
            {
                //desativa scripts após colisão do player
                Spawn.GetComponent<SpawnObstacle>().enabled = false;
                other.GetComponent<MoveObstacle>().enabled = false;
                GetComponent<Moviment>().enabled = false;
                GetComponent<Rigidbody2D>().mass = 0;
                //desativa interface
                interfacePlayer.SetActive(false);
                //ativa menu de game over
                gameOver.SetActive(true);
            }
        }
    } 
}
