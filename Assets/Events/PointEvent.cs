using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PointEvent : MonoBehaviour
{
    public UnityEvent enteredTheCollider;

    //cria eventos e quando acontecer algo vai ativar o sinal para uma outra ação ocorrer e quando sair
    //colocar as funções de hit aqui
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 7)
        {
            enteredTheCollider.Invoke();
        }
        //se colidir com o obstaculo bone e o player se mover
        else if (other.gameObject.layer == 9)
        {
            //mudar depois para mobile //////////////////////////
            //Touch touch = Input.GetTouch(0);
            //se o player segurar a tela do celular ele agacha
            //if (touch.phase == TouchPhase.Stationary || Input.GetKeyDown(KeyCode.S))
            if (GetComponent<Rigidbody2D>().velocity.y == 0 || !Input.GetKey(KeyCode.S))
            {
                enteredTheCollider.Invoke();
            }
        }
    } 
}

