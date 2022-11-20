using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fingeruebung : MonoBehaviour
{
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10] { "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", };
    GameObject[] arrayColoredImagesRed;

    void Start()
    {
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(array1[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(array1[array1.Length-1]);
        Debug.Log(array4[array1.Length-1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length-1].name);

        for (int i = 0; i < array2.length; i++)
        {
            Debug.Log("array2[" + i + "] = " + array2[i]);
        }

        for (int i = 0; i < array2.Length; i++)
        {
            longstring = longstring + array2[i] + " ";
        }

    }

   


    
   
}
