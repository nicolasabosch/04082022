using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*2.Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
Luego indicar cuánto dinero sobra o falta.*/
public class ActJero2 : MonoBehaviour
{
    public int product1;
    public int product2;
    public int product3;
    public int availableMoney;


    // Start is called before the first frame update
    void Start()
    {

        int dineroRestante = availableMoney - product1 - product2 - product3;

        int dineroFaltante= product1 +  product2 + product3 - availableMoney;
        
        if (availableMoney >= product1 + product2 + product3)
        {
            Debug.Log("hay dinero disponible para hacer la compra, y te sobra $" + dineroRestante);

        }
        
        else
        {
            Debug.Log("No tenes el dinero necesario para comprar los productos, te falta $"+ dineroFaltante);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
