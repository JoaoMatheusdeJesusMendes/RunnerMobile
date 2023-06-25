using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //variavel que guarda o nome do jogo
    [SerializeField] private string nameGame;
    
    //variavel que recebe o menu principal
    [SerializeField] private GameObject mainMenu;
    
    //variavel que recebe o menu de pontuação
    [SerializeField] private GameObject pointsMenu;
    
    //recebe o menu de opções
    [SerializeField] private GameObject optionsMenu;


    //procedimento que inicia o jogo
    public void ButtonStart()
    {
        //inicia o game
        SceneManager.LoadScene(nameGame);
    }
    
    //procedimento que inicia o menu de pontuações
    public void PointsStart()
    {
        //Desativa o menu principal
        mainMenu.SetActive(false);
        
        //Ativa o menu de pontuação
        pointsMenu.SetActive(true);
    }
    
    //procedimento que inicia as opções
    public void OptionActive()
    {
        //Desativa o menu principal
        mainMenu.SetActive(false);
        
        //Ativa o menu de opções
        optionsMenu.SetActive(true);
    }
    
    //fecha o app
    public void Close()
    {
        //fechar a aplicação
        Application.Quit();
    }
}
