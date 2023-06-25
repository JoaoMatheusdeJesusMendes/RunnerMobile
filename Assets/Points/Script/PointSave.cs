using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class PointSave : MonoBehaviour
{
    public Deque infos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //salva jogo em binario
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        //caminho de save
        string path = Application.persistentDataPath;

        FileStream file = File.Create(path + "/savegame.save");
        
        bf.Serialize(file, infos);
        file.Close();
    }
    
    //recebe valores em binario
    public void Load()
    {
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
    }
}

public class Node
{
    public int data = -1;
    public Node previous;
    public Node next;
}

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
        }
        else
        {
            aux.data = value;
            aux.previous = end;
            end = aux;
            size += 1;

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
}
