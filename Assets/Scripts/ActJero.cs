using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.*/
public class ActJero : MonoBehaviour
{
    public int num1;
    public int num2;   
    void Start()
    {

        if (num1 == num2)
        {
            Debug.Log("ambos numeros son iguales");

        }   

        else
        {
            Debug.Log("Los numeros son distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
