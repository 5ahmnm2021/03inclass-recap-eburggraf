using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToColorScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeToNumberScene()
    {
        SceneManager.LoadScene("02NumberScene");
    }

    public void ChangeToWelcomeScene()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
}
