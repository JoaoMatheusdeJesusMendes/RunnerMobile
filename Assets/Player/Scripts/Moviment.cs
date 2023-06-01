using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    //recebe rigidybody do player
    public Rigidbody2D rb;
    
    //variavel que recebe a força do pulo
    public float jumpForce = 40.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }
    
    //função de pulo
    public void Jump()
    {
        //logica de pulo
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }
    
}
