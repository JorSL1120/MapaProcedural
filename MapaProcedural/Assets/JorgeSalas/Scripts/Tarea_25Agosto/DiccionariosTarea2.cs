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
    public Dictionary<int, int> diccionarioE6;
    public Dictionary<int, int> diccionarioE6_2;

    // para ejercicio 7
    public Dictionary<string, int> diccionarioE7;

    // para ejercicio 8
    public Dictionary<int, string> diccionarioE8;

    // para ejercicio 9
    public Dictionary<string, int> diccionarioE9;

    // para ejercicio 10
    public Dictionary<string, int> diccionarioE10;
    public string claveE10;
    public int valorPorDefectoE10 = 2;



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
            Debug.Log(par.Key + " aparece " + par.Value + " veces");
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
            Debug.Log(par.Key + " aparece " + par.Value + " veces");
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
    }

    // ejercicio 4
    void ClaveValorMaximo()
    {
        string claveMaxVal = null;
        int valMax = int.MinValue;

        foreach(var par in diccionarioE4)
        {
            if(par.Value > valMax)
            {
                valMax = par.Value;
                claveMaxVal = par.Key;
            }
        }
        Debug.Log(claveMaxVal + " es la clave con maximo valor, su valor es: " + valMax);
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
    }

    // ejercicio 6
    void CombinarDiccionarios()
    {
        Dictionary<int, int> diccionarioCombinado = new Dictionary<int, int>(diccionarioE6);

        foreach(var par in diccionarioE6_2)
        {
            if(diccionarioCombinado.ContainsKey(par.Key))
            {
                diccionarioCombinado[par.Key] += par.Value;
            }
            else
            {
                diccionarioCombinado[par.Key] = par.Value;
            }
        }
    }

    // ejercicio 7
    void SumarValoresDiccionario()
    {
        int suma = 0;

        foreach(var par in diccionarioE7)
        {
            suma += par.Value;
        }
    }

    // ejercicio 8
    void InvertirDiccionario()
    {
        Dictionary<string, int> diccionarioInvertido = new Dictionary<string, int>();

        foreach(var par in diccionarioE8)
        {
            diccionarioInvertido[par.Value] = par.Key;
        }
    }

    // ejercicio 9
    void ClavesValoresPares()
    {
        foreach(var par in diccionarioE9)
        {
            if(par.Value % 2 == 0)
            {
                Debug.Log("Clave con valor par: " + par.Key);
            }
        }
    }

    // ejercicio 10
    void VerificarAgregarClave(string clave, int valorPorDefecto)
    {
        if(diccionarioE10.ContainsKey(clave))
        {
            Debug.Log("El valor de " + clave + " es: " + diccionarioE10[clave]);
        }
        else
        {
            diccionarioE10[clave] = valorPorDefecto;
            Debug.Log(clave + " no existe, se agrega con este valor: " + valorPorDefecto);
        }
    }
}
