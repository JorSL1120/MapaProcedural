using System.Collections.Generic;
using UnityEngine;

public class DiccionariosTarea2
{
    /*DICCIONARIOS (10 ejercicios)
     * 
    1. Dado un array de cadenas, cuenta cuántas veces aparece cada palabra usando un diccionario.
    2. Dada una lista de enteros, crea un diccionario donde la clave sea el número y el valor cuántas veces aparece.
    3. Intercambia las claves y valores de un diccionario.
    4. Dado un diccionario de string -> int, encuentra la clave con el valor máximo.
    5. Dado un diccionario de string -> int, elimina todas las entradas cuyo valor sea menor que 10.
    6. Combina dos diccionarios de enteros sumando los valores de claves repetidas.
    7. Dado un diccionario de string -> int, devuelve la suma de todos los valores.
    8. Dado un diccionario de int -> string, crea un diccionario invertido de string -> int.
    9. Dado un diccionario de string -> int, imprime todas las claves cuyos valores son pares.
    10. Dado un diccionario, verifica si existe una clave determinada y devuelve su valor; si no existe, agrega la clave con un valor por defecto.
    */

    // para ejercicio 1
    public string[] arrayStringE1;

    // para ejercicio 2
    public List<int> listaEnterosE2;

    // para ejercicio 3
    public Dictionary<string, int> diccionarioE3;

    // para ejercicio 4
    public Dictionary<string, int> diccionarioE4;

    // para ejercicio 5
    public Dictionary<string, int> diccionarioE5;

    // para ejercicio 6

    // para ejercicio 7

    // para ejercicio 8

    // para ejercicio 9

    // para ejercicio 10



    // ejericio 1
    void ConteoPalabras()
    {
        Dictionary<string, int> conteo = new Dictionary<string, int>();
        foreach(string palabra in arrayStringE1)
        {
            if(conteo.ContainsKey(palabra))
            {
                conteo[palabra]++;
            }
            else
            {
                conteo[palabra] = 1;
            }
        }
        foreach(var par in conteo)
        {
            Debug.Log("La palabra " + par.Key + " aparece " + par.Value + "veces");
        }
    }

    // ejercicio 2
    void ConteoNumeros()
    {
        Dictionary<int, int> conteo = new Dictionary<int, int>();
        foreach (int numero in listaEnterosE2)
        {
            if (conteo.ContainsKey(numero))
            {
                conteo[numero]++;
            }
            else
            {
                conteo[numero] = 1;
            }
        }
        foreach (var par in conteo)
        {
            Debug.Log("El número " + par.Key + " aparece " + par.Value + " veces");
        }
    }

    // ejercicio 3
    void IntercambiarClavesValores()
    {
        Dictionary<int, string> diccionarioInvertido = new Dictionary<int, string>();

        foreach(var par in diccionarioE3)
        {
            diccionarioInvertido[par.Value] = par.Key;
        }

        foreach(var par in diccionarioInvertido)
        {
            Debug.Log("Clave: " + par.Key + ", Valor: " + par.Value);
        }
    }

    // ejercicio 4
    void ClaveValorMaximo()
    {
        string claveMaxima = null;
        int valorMaximo = int.MinValue;

        foreach(var par in diccionarioE4)
        {
            if(par.Value > valorMaximo)
            {
                valorMaximo = par.Value;
                claveMaxima = par.Key;
            }
        }
        Debug.Log("La clave con el valor máximo es: " + claveMaxima + " con un valor de: " + valorMaximo);
    }

    // ejercicio 5
    void EliminarEntradasMenoresQueDiez()
    {
        List<string> clavesAEliminar = new List<string>();
        foreach(var par in diccionarioE5)
        {
            if(par.Value < 10)
            {
                clavesAEliminar.Add(par.Key);
            }
        }
        foreach(string clave in clavesAEliminar)
        {
            diccionarioE5.Remove(clave);
        }
        foreach(var par in diccionarioE5)
        {
            Debug.Log("Clave: " + par.Key + ", Valor: " + par.Value);
        }
    }
}
