using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    private int puntaje;
    private GameObject jugador;
    private Text textopuntaje;

    private int vida;

    public int init;


    // Start is called before the first frame update
    void Start()
    {
        textopuntaje.text = "0";

        for (int i = 0; i < 10; i++)
        {

        }
        Addpuntaje(2);
        Addpuntaje(15);

        Vector3 vector = new Vector3(10, 0, -5);
    }

    //me permite aumentar mi puntaje
    public void Addpuntaje(int value)
    {
        puntaje += value;
    }

    /*
    public void Addpuntaje(int value, int value1)
    {
        puntaje += (value +value1);
    }

    public void Addpuntaje(int value, int value1, int value2)
    {
        puntaje += (value + value1 + value2);
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (vida == 0)
        {
            textopuntaje.text = "perdiste: 0";
        }
        else
        {

        }
    }
}
