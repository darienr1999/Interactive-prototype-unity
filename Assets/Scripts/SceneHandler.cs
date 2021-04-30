using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void ToSplash() 
    {
        SceneManager.LoadScene("Splash");
    }

    public void ToIntro() {

        SceneManager.LoadScene("Intro");
    }

    public void ToInstructions() {
        SceneManager.LoadScene("Instructions");
    }

    public void ToGame() 
    {
        SceneManager.LoadScene("3rdPerson+Fly");
    }
}
