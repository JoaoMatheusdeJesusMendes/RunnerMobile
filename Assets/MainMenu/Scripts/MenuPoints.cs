using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuPoints : MonoBehaviour
{
    
    //Recebe o local de escrita do numero de moedas
    public TextMeshProUGUI pont;

    //variavel que recebera os dados
    private PointSave point;
    
    // Start is called before the first frame update
    void Start()
    {
        BestPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //mostra melhor pontuação
    private void BestPoint()
    {
        point.Load();
        pont.text = "Maior Pontuação: " + point.higgest;
    }
}
