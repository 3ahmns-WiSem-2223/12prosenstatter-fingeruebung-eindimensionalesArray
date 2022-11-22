using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fingeruebung : MonoBehaviour
{
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10] { "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4" };
    GameObject[] arrayColoredImagesRed;

    void Start()
    {
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(array1[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array4[array1.Length - 1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);

        for (int i = 0; i <= array4.Length; i++)
        {
            Debug.Log("Element null =" + array4[0]);
            Debug.Log("Element eins =" + array4[1]);
            Debug.Log("Element zwei =" + array4[2]);
            Debug.Log("Element drei =" + array4[3]);
            Debug.Log("Element vier =" + array4[4]);
        }



        for (int i = 0; i < array2.Length; i++)
        {
            Debug.Log(array2[0] + array2[1] + array2[2] + array2[3]);
            //          ist nicht so möglich  
        }


        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[2].GetComponent<Image>().color = new Color32(0, 137, 0, 255);



        int[] array5 = new int[51];
        for (int i = 0; i < array5.Length; i++)
        {
            if (i % 2 == 0)
            {
                array5[i] = i + 20;
            }

        }

        int[] array6 = new int[501];
        for (int i = 0; i < array6.Length; i++)
        {
            if (i % 2 == 0)
            {
                array6[i] = i;
            }

        }

        int[] array7 = new int[501];
        for (int i = 0; i < array7.Length; i++)
        {
            if (i % 2 == 1)
            {
                array7[i] = i;
            }

        }








    }

}






