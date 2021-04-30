using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{
    public Canvas page1;
    public Canvas page2;
    public Button kjBox;
    public Canvas kjDetails;
    public Button atBox;
    public Canvas atDetails;
    public Button alBox;
    public Canvas alDetails;
    public Button nextButton;
    public Button prevButton;
    public Button startButton;
    private int numRevealed;

    void Start()
    {
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
        kjBox.gameObject.SetActive(true);
        atBox.gameObject.SetActive(true);
        alBox.gameObject.SetActive(true);
        kjDetails.gameObject.SetActive(false);
        atDetails.gameObject.SetActive(false);
        alDetails.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
        prevButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        numRevealed = 0;
    }

    void Update()
    {
        if (numRevealed == 3 && !nextButton.gameObject.activeSelf && page1.gameObject.activeSelf)
        {
            nextButton.gameObject.SetActive(true);
        }
    }

    public void ShowDetailsKJ()
    {
        kjBox.gameObject.SetActive(false);
        kjDetails.gameObject.SetActive(true);
        Debug.Log("KJ: box " + kjBox.enabled + " // details " + kjDetails.enabled);
        numRevealed++;
    }

    public void ShowDetailsAT()
    {
        atBox.gameObject.SetActive(false);
        atDetails.gameObject.SetActive(true);
        Debug.Log("AT: box " + atBox.enabled + " // details " + atDetails.enabled);
        numRevealed++;
    }

    public void ShowDetailsAL()
    {
        alBox.gameObject.SetActive(false);
        alDetails.gameObject.SetActive(true);
        Debug.Log("AL: box " + alBox.enabled + " // details " + alDetails.enabled);
        numRevealed++;
    }

    public void NextPage()
    {
        page1.gameObject.SetActive(false);
        page2.gameObject.SetActive(true);
        nextButton.gameObject.SetActive(false);
        prevButton.gameObject.SetActive(true);
        startButton.gameObject.SetActive(true);
        Debug.Log("Instructions Page 2/2");
    }

    public void PrevPage()
    {
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(true);
        prevButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        Debug.Log("Instructions Page 1/2");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("3rdPerson+Fly");
    }
}
