using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
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

    }

    // Update is called once per frame
    void Update()
    {

        if (vida == 0)
        {
            textopuntaje.text = "perdiste: #{puntaje}";
        }
        else
        {

        }
    }
}
