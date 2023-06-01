using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    //variavel que recebe valores do slider
    public Slider volume;

    //recebe o audio mixer
    [SerializeField] private AudioMixer aMixer;
    
    //variavel que recebe o menu principal
    [SerializeField] private GameObject mainMenu;
    
    //recebe o menu de opções
    [SerializeField] private GameObject optionsMenu;

    private void Start()
    {
        //o volume inicial é 0
        volume.value = 0;
        
        //começa o audio mixer de tudo como 0
        aMixer.SetFloat("VolumeGame", -80);
    }

    //função que inicia ao menu inicial 
    public void OptionReturn()
    {
        //Desativa o menu principal
        mainMenu.SetActive(true);
        
        //Ativa o menu de opções
        optionsMenu.SetActive(false);
    }
    
    //função do slider das opções
    public void SliderVolume()
    {
        aMixer.SetFloat("VolumeGame", -80 + (volume.value * 17));
    }
}
