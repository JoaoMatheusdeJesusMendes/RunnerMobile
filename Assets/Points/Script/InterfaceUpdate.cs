using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceUpdate: MonoBehaviour
{
    //variavel que recebe o player
    [SerializeField] private GameObject player;

    //variavel que recebe o script de pontos feitos
    private PointMaker point;

    //Recebe o local de escrita do numero de moedas
    public TextMeshProUGUI pont;
    

    // Start is called before the first frame update
    void Start()
    {
        point = player.GetComponent<PointMaker>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI();
    }
    

    //função que escreve as moedas coletadas na interface
    void ScoreUI()
    {
        pont.text = "Pontos: " + point.points.ToString();
    }
}
