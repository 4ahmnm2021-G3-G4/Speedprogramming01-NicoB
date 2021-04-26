using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeAddition : MonoBehaviour
{
    [SerializeField]
    InputField inputField1;
    [SerializeField]
    InputField inputField2;
    [SerializeField]
    Button buttonAdd;
    int result;
    public void AddNumbers()
    {
        result = int.Parse(inputField1.text) + int.Parse(inputField2.text);
        GetComponent<Text>().text = result.ToString();
        buttonAdd.interactable = false;
        inputField1.interactable = false;
        inputField2.interactable = false;
    }
}
