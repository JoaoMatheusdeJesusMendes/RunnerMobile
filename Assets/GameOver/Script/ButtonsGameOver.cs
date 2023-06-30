using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGameOver : MonoBehaviour
{
    //variavel que recebe o menu principal 
    [SerializeField] private string mainMenu;
    
    //variavel que recebe o game
    [SerializeField] private string game;
    
    //pega o rigidybody do player
    [SerializeField] private GameObject player;
    
    //pega o script de guardar pontos
    public PointSave pointSave;
    
    // Start is called before the first frame update
    void Start()
    {
        pointSave = player.GetComponent<PointSave>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //reinicia o game
    public void Restart()
    {
        SceneManager.LoadScene(game);
    }
    
    //volta para o menu principal
    public void ReturnMainMenu()
    {
        //salva em arquivo
        pointSave.Save();
        SceneManager.LoadScene(mainMenu);
    }
}
