using System;
using UnityEngine;

public class Arrays
{
    //Ejercicio 1
    public string[] stringArrayE1 = new string[4];

    //Ejercicio 2
    public string[] stringArrayE2 = new string[5];

    //Ejercicio 3
    public int[,] intArrayE3 = new int[4,2];

    //Ejercicio 4
    public int[][] arrayDeArraysE4 = new int[1][];


    void ArraysEjercicio1()
    {
        stringArrayE1[3] = "0";
        Debug.Log(stringArrayE1[3]);
    }

    void ArraysEjercicio2()
    {
        for(int i = 0;  i < stringArrayE2.Length; i++)
        {
            stringArrayE2[i] = "1";
        }
    }

    void ArraysEjercicio4()
    {

    }

    void ArraysEjercicio5()
    {
        Array.Resize(ref stringArrayE1, 3);
    }
}
