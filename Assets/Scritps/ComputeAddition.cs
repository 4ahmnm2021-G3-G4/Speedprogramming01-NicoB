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
        try
        {
            result = int.Parse(inputField1.text) + int.Parse(inputField2.text);
            inputField1.image.color = Color.white;
            inputField2.image.color = Color.white;
        }
        catch (System.Exception)
        {
            inputField1.image.color = Color.red;
            inputField2.image.color = Color.red;
            GetComponent<Text>().text = "Gib eine Zahl ein!";
            return;
        }
        GetComponent<Text>().text = result.ToString();
        buttonAdd.interactable = false;
        inputField1.interactable = false;
        inputField2.interactable = false;
    }
}
