using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionController : MonoBehaviour
{
    public Canvas decisionScreen;
    public Canvas ALscreen;
    public Canvas ATscreen;
    public Canvas KJscreen;
    // Start is called before the first frame update
    void Start()
    {
        decisionScreen.gameObject.SetActive(true);
        ALscreen.gameObject.SetActive(false);
        ATscreen.gameObject.SetActive(false);
        KJscreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseAL()
    {
        decisionScreen.gameObject.SetActive(false);
        ALscreen.gameObject.SetActive(true);
    }

    public void ChooseAT()
    {
        decisionScreen.gameObject.SetActive(false);
        ATscreen.gameObject.SetActive(true);
    }

    public void ChooseKJ()
    {
        decisionScreen.gameObject.SetActive(false);
        KJscreen.gameObject.SetActive(true);
    }
}
