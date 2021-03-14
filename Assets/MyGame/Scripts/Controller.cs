using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
   
    public InputField iFieldA;

    public InputField iFieldB;

    public float finalWert;

    public Text sumtxt;

    public Text Error;

    public Color red = Color.red;

    public Color white = Color.white;

    public float InputAFloat;

    public float InputBFloat;

    public void LoadNextSceneAutomated()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChangeToWelcomeScene()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
    public void ButtonAdd()
    {
        try
        {
            InputAFloat = float.Parse(iFieldA.text);
            iFieldA.image.color = white;
        }

        catch(System.Exception)
        {
            iFieldA.image.color = red;
            Error.text = "Error! Enter A Number!";
        }

        try
        {
            InputBFloat = float.Parse(iFieldB.text);
            iFieldB.image.color = white;
        }

        catch (System.Exception)
        {
            iFieldB.image.color = red;
            Error.text = "Error! Enter A Number!";
        }

        finalWert = float.Parse(iFieldA.text) + float.Parse(iFieldB.text);
        Debug.Log(finalWert);
        sumtxt.text = finalWert.ToString();
    }

}
