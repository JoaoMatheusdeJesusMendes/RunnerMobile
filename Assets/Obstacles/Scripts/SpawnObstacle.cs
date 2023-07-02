using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    //variavel que recebe o obstaculo aéreo
    public GameObject airObstacle;
    
    //variavel que recebe o obstaculo terrestre
    public GameObject soloObstacle;
    
    //variavel que recebe o obstaculo que não pode se mover
    public GameObject bone;
    
    //variavel que recebe posição de spawn aérea
    public Transform airSpawn;
    
    //variavel que recebe posição de spawn terrestre
    public Transform soloSpawn;
    
    //variavel que recebe posição de spawn do obstaculo que não pode se mexer
    public Transform boneSpawn;
    
    //variavel que recebe a randomização de um numero para decidir o obstaculo
    private int randObst = 0;
    
    //variavel que randomiza o tempo
    private int timeSpawn = 0;
    
    //variavel que conta o tempo
    private int time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //se a variavel randObst for igual a 0 randomiza o obstaculo
        if (randObst == 0)
        {
            //randomiza o numero para o obstaculo
            randObst = Random.Range(1, 4);
        }
            
            
        //se tempo igual a 0 randomiza tipo de spawn
        if (time == 0)
        {
            //randomiza o tempo de spawn para os objetos
            timeSpawn = Random.Range(3, 7);
        }
        
        //verifica se o tempo é igual ao designado para spawnar o proximo obstaculo
        if (time >= timeSpawn)
        {
            //chama função de spawn
            SpawnObst(randObst);
            //reseta os contadores
            time = 0;
            timeSpawn = 0;
            randObst = 0;
        }
    }

    private void Timer()
    {
        time += 1;
    }
    private void SpawnObst(int aux)
    {
        //se variavel é 1 spawna obstaculo aéreo
        if (aux == 1)
        {
            Vector2 spawnPosition = new Vector2(airSpawn.position.x, airSpawn.position.y);
            Instantiate(airObstacle, spawnPosition, Quaternion.identity);
        }
        
        //se variavel é 2 spawna obstaculo terrestre
        if (aux == 2)
        {
            Vector2 spawnPosition = new Vector2(soloSpawn.position.x, soloSpawn.position.y);
            Instantiate(soloObstacle, spawnPosition, Quaternion.identity);
        }
        
        //se variavel é 3 spawna obstaculo que não pode se mover
        if (aux == 3)
        {
            Vector2 spawnPosition = new Vector2(boneSpawn.position.x, boneSpawn.position.y);
            Instantiate(bone, spawnPosition, Quaternion.identity);
        }
    }
}
