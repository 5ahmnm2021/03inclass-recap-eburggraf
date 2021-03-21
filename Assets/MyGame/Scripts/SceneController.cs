﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadNextSceneAutomated()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChangeToWelcomeScene()
    {
        SceneManager.LoadScene("00WelcomeScene");

    }
}
