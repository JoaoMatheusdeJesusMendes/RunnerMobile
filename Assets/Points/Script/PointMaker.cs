using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMaker : MonoBehaviour
{
    public int points = 0;
    
    //pega o rigidybody do player
    [SerializeField] private GameObject player;
    
    //pega o script de guardar pontos
    private PointSave pointSave;
    
    // Start is called before the first frame update
    void Start()
    {
        pointSave = player.GetComponent<PointSave>();
        pointSave.LoadPoints();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointMakerPlayer()
    {
        points += 1;
    }
}
