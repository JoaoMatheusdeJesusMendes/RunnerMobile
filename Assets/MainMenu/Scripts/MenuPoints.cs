using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuPoints : MonoBehaviour
{
    
    //Recebe o local de escrita da maior pontuação
    public TextMeshProUGUI pont;
    
    //Recebe o local de escrita das ultimas pontuações
    public TextMeshProUGUI lastPont;

    //variavel que recebera os dados
    private PointSave point;
    
    // Start is called before the first frame update
    void Start()
    {
        point = new PointSave();
    }

    // Update is called once per frame
    void Update()
    {
        BestPoint();
        LastPoints();
    }

    //mostra melhor pontuação
    private void BestPoint()
    {
        point.LoadPoints();
        pont.text = "Maior Pontuacao: " + point.higgest;
    }

    private void LastPoints()
    {
        lastPont.text = "Ultima Pontuacao: " + point.infos[2] + "\n" + "Penultima Pontuacao: " + point.infos[1] + "\n" +
                        "Antepenultima Pontuacao: " + point.infos[0];
    }
}
