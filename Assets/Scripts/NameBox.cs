using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class NameBox : MonoBehaviour
{
    [SerializeField] private string inputText;



    public void Edited(string input)
    {
        inputText = input;
        Debug.Log(inputText);
    }

}
