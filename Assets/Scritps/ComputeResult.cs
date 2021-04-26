using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeResult : MonoBehaviour
{
    [SerializeField] Toggle toggle1;
    [SerializeField] Toggle toggle2;
    [SerializeField] Button button1;
    [SerializeField] Button button2;

    bool toggleOneTrue;
    bool toggleTwoTrue;

    public void ComputeResultButton(bool andPressed)
    {
        toggleOneTrue = toggle1.GetComponent<Toggle>().isOn;
        toggleTwoTrue = toggle2.GetComponent<Toggle>().isOn;
        if (andPressed)
        {
            if (toggleOneTrue && toggleTwoTrue)
            {
                GetComponent<Text>().text = "Wahr";
            }
            else
            {
                GetComponent<Text>().text = "Falsch";
            }
        }
        else
        {
            if (!toggleOneTrue && !toggleTwoTrue)
            {
                GetComponent<Text>().text = "Falsch";
            }
            else
            {
                GetComponent<Text>().text = "Wahr";
            }
        }
        button1.interactable = false;
        button2.interactable = false;
        toggle1.interactable = false;
        toggle2.interactable = false;
    }
}
