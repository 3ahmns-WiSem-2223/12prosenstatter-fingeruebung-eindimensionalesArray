using UnityEngine;
using TMPro;



public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI text;



    public int number;

    public void More()
    {
        number++;
        text.text = number.ToString();
    }
    public void Less()
    {
        number--;
        text.text = number.ToString();
    }
}