using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    bool isTrue = true;
    public void SwitchedToggle()
    {
        if (isTrue)
        {
            GetComponent<Text>().text = "Falsch";
            isTrue = false;
        }
        else
        {
            GetComponent<Text>().text = "Wahr";
            isTrue = true;
        }
    }
}
