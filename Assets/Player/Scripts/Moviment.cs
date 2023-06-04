using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    //recebe rigidybody do player
    public Rigidbody2D rb;
    
    //variavel que recebe a força do pulo
    public float jumpForce = 40.0f;
    
    [SerializeField] private Transform feetPosition;

    [SerializeField] private LayerMask groundLayer;

    //variavel para controle se ele está no chão
    public bool isGround;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cria uma area para conferir se o player esta tocando o chão
        isGround = Physics2D.OverlapCircle(feetPosition.position, 0.1f, groundLayer);
        //se player tocar na tela ele ira pular
        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.W))
        {
            //se está no chão
            if (isGround)
            {
                Jump();
            }
        }
        //mudar depois para mobile //////////////////////////
        //Touch touch = Input.GetTouch(0);
        //se o player segurar a tela do celular ele agacha
        //if (touch.phase == TouchPhase.Stationary || Input.GetKeyDown(KeyCode.S))
        if(Input.GetKeyDown(KeyCode.S))
        { 
            Squat();
        }
        //se ele parar de segurar volta ao tamanho normal
        //if (touch.phase == TouchPhase.Ended || Input.GetKeyUp(KeyCode.S))
        if(Input.GetKeyUp(KeyCode.S))
        { 
            Up();
        }
        
    }
    
    //função de pulo
    private void Jump()
    {
        //logica de pulo
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }
    
    //função para o personagem agachar
    private void Squat()
    {
        //logica de agachar
        rb.transform.localScale = new Vector3(rb.transform.localScale.x, rb.transform.localScale.y / 2,
            rb.transform.localScale.z);
    }
    
    //função do personagem levantar
    private void Up()
    {
        //logica de agachar
        rb.transform.localScale = new Vector3(rb.transform.localScale.x, rb.transform.localScale.y * 2,
            rb.transform.localScale.z);
    }
}
