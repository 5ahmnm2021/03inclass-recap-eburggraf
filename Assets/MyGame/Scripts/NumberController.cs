using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public InputField iFieldA;
    public InputField iFieldB;

    public Text sumTxt;
   
    bool num1 = true;
    bool num2 = true;

    public void ButtonAdd()
    {
        string errorMsg = "Error!";

        float inputAFloat = 0;

        float inputBFloat = 0;

        float finalWert;

        try
        {
            inputAFloat = float.Parse(iFieldA.text);
            iFieldA.image.color = Color.white;
            num1 = true;
        }

        catch (System.Exception)
        {
            iFieldA.image.color = Color.red;
            iFieldA.text = errorMsg;
            num1 = false;
        }

        try
        {
            inputBFloat = float.Parse(iFieldB.text);
            iFieldB.image.color = Color.white;
            num2 = true;
        }

        catch (System.Exception)
        {
            iFieldB.image.color = Color.red;
            iFieldB.text = errorMsg;
            num2 = false;
        }

        if (num1 && num2)
        {
            finalWert = inputAFloat + inputBFloat;
            sumTxt.text = finalWert.ToString();
        }   
    }
}
