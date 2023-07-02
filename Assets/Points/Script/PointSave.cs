using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PointSave : MonoBehaviour
{
    public int higgest = -1;
    public int [] infos = new int[3];
    private int size = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //salva jogo
    public void SavePoints()
    {
        //string json = JsonUtility.ToJson(infos);
        //salva informações do player
        if (size >= 1)
        {
            PlayerPrefs.SetInt("points1", infos[0]);
            PlayerPrefs.Save();
        }
        if (size >= 2)
        {
            PlayerPrefs.SetInt("points2", infos[1]);
            PlayerPrefs.Save();
        }
        if (size >= 3)
        {
            PlayerPrefs.SetInt("points3", infos[2]);
            PlayerPrefs.Save();
        }
        PlayerPrefs.SetInt("maior", higgest);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("tamanho", size);
        PlayerPrefs.Save();
        /*
        BinaryFormatter bf = new BinaryFormatter();
        //caminho de save
        string path = Application.persistentDataPath;

        FileStream file = File.Create(path + "/savegame.save");
        
        bf.Serialize(file, infos);
        file.Close();
        */
    }
    
    //recebe valores salvos
    public void LoadPoints()
    { 
        if (!PlayerPrefs.HasKey("points1"))
        {
            print("Não achou arquivo salvo");
        }
        size = PlayerPrefs.GetInt("tamanho");
        
        if (size >= 1)
        {
            infos[0] = PlayerPrefs.GetInt("points1");
            PlayerPrefs.Save();
        }
        if (size >= 2)
        {
            infos[1] = PlayerPrefs.GetInt("points2");
            PlayerPrefs.Save();
        }
        if (size >= 3)
        {
            infos[2] = PlayerPrefs.GetInt("points3");
            PlayerPrefs.Save();
        }
        //string json = PlayerPrefs.GetString("points");
        //infos = JsonUtility.FromJson<int[]>(json);
        higgest = PlayerPrefs.GetInt("maior");
        
        /*
        BinaryFormatter bf = new BinaryFormatter();
        //caminho de save
        string path = Application.persistentDataPath;

        FileStream file;

        if (File.Exists(path + "savegame.save"))
        {
            file = File.Open(path + "savegame.save", FileMode.Open);
            infos = (Deque)bf.Deserialize(file);
            file.Close();
        }
        */
    }
    
    //adiciona ao vetor
    public void addFila(int value)
    {
        //ajusta maior valor
        Higgest(value);
        //se é a primeira adição
        if (size == 0)
        {
            infos[size] = value;
            size++;
        }
        //para proximas adições
        else
        {
            if (size == 3)
            {
                //move todos valores de posição
                infos[0] = infos[1];
                infos[1] = infos[2];
                infos[2] = value;
            }

            if (size < 3)
            {
                infos[size] = value;
                size++;
            }
        }
    }
    
    //ajusta maior valor
    private void Higgest(int value)
    {
        if (value > higgest)
        {
            higgest = value;
        }
    }
}
/*
[Serializable]
public class Node
{
    public int data = -1;
    public Node previous;
    public Node next;
}

[Serializable]
public class Deque
{
    //fim do deque
    public Node end;
    
    //começo do deque
    public Node first;
    
    //variavel auxiliar
    private Node aux;
    
    //tamanho do deque
    public int size = 0;

    //maior valor
    public int higgest;
    
    //adiciona falor ao final do deque
    public void addDeque(int value)
    {
        if (size == 0)
        {
            end.data = value;
            first.data = value;
            size += 1;
            higgest = value;
        }
        else
        {
            if (size == 1)
            {
                aux.data = value;
                aux.previous = end;
                first.next = aux;
                end = aux;
                size += 1;
                higgest = higgestValue();
            }
            else
            {
                aux.data = value;
                aux.previous = end;
                end = aux;
                size += 1;
                higgest = higgestValue();
            }
            
            if (size > 3)
            {
                removeDeque();
            }
        }
    }
    
    //remove valor
    public void removeDeque()
    {
        first = first.next;
    }

    //maior valor
    public int higgestValue()
    {
        aux = first;
        for (int i = 0; i < size; i++)
        {
            if (aux.data > higgest)
            {
                higgest = aux.data;
            }
            aux = aux.next;
        }

        return higgest;
    }  
}*/
