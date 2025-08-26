using System.Collections.Generic;
using UnityEngine;

public class ListasTarea2
{
    /*LISTAS (10 ejercicios)
     
    1. Dada una lista de enteros, elimina todos los elementos duplicados.
    2. Dada una lista de enteros, intercambia el primer y el último elemento.
    3. Dada una lista de cadenas, filtra todas las cadenas que contengan más de 5 caracteres.
    4. Dada una lista de enteros, encuentra el segundo número más grande.
    5. Combina dos listas de enteros en una sola lista sin duplicados.
    6. Dada una lista de enteros, invierte el orden de los elementos.
    7. Dada una lista de enteros, elimina todos los números impares.
    8. Dada una lista de enteros, encuentra los números que aparecen más de una vez.
    9. Dada una lista de enteros, calcula la suma de los elementos en posiciones pares.
    10. Dada una lista de enteros, inserta un valor en la posición n sin usar Insert().
    */

    // para ejercicio 1
    public List<int> listaEnterosE1;

    // para ejercicio 2
    public List<int> listaEnterosE2;

    // para ejercicio 3
    public List<string> listaStringE3;

    // para ejercicio 4
    public List<int> listaEnterosE4;

    // para ejercicio 5

    // para ejercicio 6

    // para ejercicio 7

    // para ejercicio 8

    // para ejercicio 9

    // para ejercicio 10



    // ejercicio 1
    void EliminaDublipados()
    {
        List<int> listaSinDuplicados = new List<int>();

        foreach(int valor in listaEnterosE1)
        {
            if(!listaSinDuplicados.Contains(valor)) listaSinDuplicados.Add(valor);
        }
    }

    // ejercicio 2
    void IntercambioPrimeroUltimo()
    {
        if(listaEnterosE2.Count < 2) return;

        int valInicio = listaEnterosE2[0];
        listaEnterosE2[0] = listaEnterosE2[listaEnterosE2.Count - 1];
        listaEnterosE2[listaEnterosE2.Count - 1] = valInicio;
    }

    // ejercicio 3
    void StringsMas5Caracteres()
    {
        List<string> listaFiltrada = new List<string>();

        foreach(string str in listaStringE3)
        {
            if(str.Length <= 5) listaFiltrada.Add(str);
        }
    }

    // ejercicio 4
    void SegundoMasGrande()
    {
        if(listaEnterosE4.Count < 2) return;

        int valMax = int.MinValue;
        int valMaxSegundo = int.MinValue;

        foreach(int valor in listaEnterosE4)
        {
            if(valor > valMax)
            {
                valMaxSegundo = valMax;
                valMax = valor;
            }
            else if(valor > valMaxSegundo && valor < valMax) valMaxSegundo = valor;
        }
        Debug.Log(valMaxSegundo + " es el segundo valor mas grande");
    }
}
