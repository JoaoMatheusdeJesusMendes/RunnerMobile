using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveObstacle : MonoBehaviour
{
    //determina velocidade de movimento
    public float speedObstacle = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    //função de movimentação do player
    private void move()
    {
        //move obstaculo para esquerda
        transform.Translate(Vector2.left * speedObstacle * Time.deltaTime);
        //float translate = (Input.GetAxis("Horizontal") * -speedObstacle);
        //rb.velocity = new Vector2(translate, rb.velocity.y);
    }
}
