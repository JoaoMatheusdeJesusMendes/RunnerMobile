using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class EventClick : MonoBehaviour
{
    //variavel do evento
    public UnityEvent touchedEvent;

    private void tochFunction()
    {
        //detecta toque na tela
        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.W))
        {
            touchedEvent.Invoke();
            Debug.Log("AAAAAA");
        }
    }
}
