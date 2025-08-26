using System;
using UnityEngine;

public class ArraysTarea2
{
    /*ARRAYS (10 ejercicios)

    1. Dado un array de enteros, encuentra el valor máximo y el mínimo.
    2. Dado un array de enteros, calcula la suma y el promedio de sus elementos.
    3. Invierte un array sin usar métodos integrados como Array.Reverse().
    4. Dado un array de enteros, elimina los duplicados y devuelve un nuevo array.
    5. Dado un array de enteros, encuentra todos los pares que sumen un número dado n.
    6. Mueve todos los ceros de un array al final, manteniendo el orden relativo de los otros números.
    7. Dado un array de enteros, determina si está ordenado de manera ascendente.
    8. Dado un array de enteros, rota sus elementos k posiciones a la derecha.
    9. Dado un array de enteros, devuelve el subarray contiguo con la suma máxima (problema de “Maximum Subarray”).
    10. Dado un array de cadenas, encuentra la cadena más larga.
    */

    // para ejercicio 1
    public int[] arrayEnterosE1;

    // para ejercicio 2
    public int[] arrayEnterosE2;

    // para ejercicio 3
    public int[] arrayEnterosE3;

    // para ejercicio 4
    public int[] arrayEnterosE4;

    // para ejercicio 5
    public int n = 10;
    public int[] arrayEnterosE5;



    // ejercicio 1
    void MaximoMinimo()
    {
        int valMax = arrayEnterosE1[0];
        int valMin = arrayEnterosE1[0];

        for(int i = 0; i < arrayEnterosE1.Length; i++)
        {
            if(arrayEnterosE1[i] > valMax) valMax = arrayEnterosE1[i];
            if(arrayEnterosE1[i] < valMin) valMin = arrayEnterosE1[i];
        }
    }

    // ejercicio 2
    void SumaPromedio()
    {
        int suma = 0;
        float promedio = 0f;

        for (int i = 0; i < arrayEnterosE2.Length; i++)
        {
            arrayEnterosE2[i] += suma;
        }
        promedio = suma / arrayEnterosE2.Length;
    }

    // ejercicio 3
    void InvertirArray()
    {
        int[] arrayInvertido = new int[arrayEnterosE3.Length];

        for(int i = 0; i < arrayEnterosE3.Length; i++)
        {
            arrayInvertido[arrayEnterosE3.Length - 1 - i] = arrayEnterosE3[i];
        }
    }

    // ejercicio 4
    void EliminaDuplicados()
    {
        int[] arrayTemporal = new int[arrayEnterosE4.Length];
        int contador = 0;

        for(int i = 0; i < arrayEnterosE4.Length; i++)
        {
            bool duplicado = false;
            for(int j = 0; j < contador; j++)
            {
                if(arrayEnterosE4[i] == arrayTemporal[j])
                {
                    duplicado = true;
                    break;
                }
            }
            if(!duplicado)
            {
                arrayTemporal[contador] = arrayEnterosE4[i];
                contador++;
            }
        }

        int[] arrayNoDuplicados = new int[contador];
        for(int i = 0; i < contador; i++)
        {
            arrayNoDuplicados[i] = arrayTemporal[i];
        }
    }

    // ejercicio 5
    void ParejasQueSumenN(int n)
    {
        for(int i = 0; i < arrayEnterosE5.Length; i++)
        {
            for(int j = i + 1; j < arrayEnterosE5.Length; j++)
            {
                if((arrayEnterosE5[i] + arrayEnterosE5[j]) == n) Console.WriteLine("La suma de " + arrayEnterosE5[i] + " + " + arrayEnterosE5[j] + " = " + n);
            }
        }
    }
}

