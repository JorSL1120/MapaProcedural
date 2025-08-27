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
    public List<int> listaEnterosE5;
    public List<int> listaEnterosE5_2;

    // para ejercicio 6
    public List<int> listaEnterosE6;

    // para ejercicio 7
    public List<int> listaEnterosE7;

    // para ejercicio 8
    public List<int> listaEnterosE8;

    // para ejercicio 9
    public List<int> listaEnterosE9;

    // para ejercicio 10
    public List<int> listaEnterosE10;
    public int valor = 0;
    public int n = 0;



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

    // ejercicio 5
    void Combinar2Listas()
    {
        List<int> listaCombinada = new List<int>(listaEnterosE5);
        foreach(int valor in listaEnterosE5_2)
        {
            if(!listaCombinada.Contains(valor)) listaCombinada.Add(valor);
        }
    }

    // ejercicio 6
    void InvertirLista()
    {
        List<int> listaInvertida = new List<int>(listaEnterosE6.Count);
        for(int i = 0; i < listaEnterosE6.Count; i++)
        {
            listaInvertida.Add(listaEnterosE6[listaEnterosE6.Count - 1 - i]);
        }
    }

    // ejercicio 7
    void EliminarImpares()
    {
        listaEnterosE7.RemoveAll(val => val % 2 != 0);
    }

    // ejercicio 8
    void EncontrarDuplicados()
    {
        List<int> listaDuplicados = new List<int>();
        List<int> guardados = new List<int>();

        foreach(int valor in listaEnterosE8)
        {
            if(guardados.Contains(valor) && !listaDuplicados.Contains(valor))
            {
                listaDuplicados.Add(valor);
            }
            else
            {
                guardados.Add(valor);
            }
        }
    }

    // ejercicio 9
    void PosicionesParesSuma()
    {
        int suma = 0;
        for(int i = 0; i < listaEnterosE9.Count; i += 2)
        {
            suma += listaEnterosE9[i];
        }

        Debug.Log("Las posiciones pares suman: " + suma);
    }

    // ejercicio 10
    void ValorPosicionN(int valor, int n)
    {
        if (n < 0 || n > listaEnterosE10.Count) return;

        listaEnterosE10.Add(0);
        for(int i = listaEnterosE10.Count - 1; i > n; i--)
        {
            listaEnterosE10[i] = listaEnterosE10[i - 1];
        }
        listaEnterosE10[n] = valor;
    }
}
