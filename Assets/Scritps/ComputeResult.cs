using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeResult : MonoBehaviour
{
    [SerializeField] Toggle toggle1;
    [SerializeField] Toggle toggle2;

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
    }
}
