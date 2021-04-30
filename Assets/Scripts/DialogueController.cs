using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{

    public float delay = 0.1f;
    public GameObject continueButton;
    private string currLine = "";

    // Start is called before the first frame update
    void Start()
    {
        continueButton.SetActive(false);
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowText()
    {
        StartCoroutine(ShowLine("YOU: What...Why am I in a hospital...The explosion!"));
        yield return new WaitForSeconds(8.0f);
        currLine = "";

        StartCoroutine(ShowLine("YOU: All my evidence must have been destroyed when they blew up my computer..."));
        yield return new WaitForSeconds(10.0f);
        currLine = "";

        StartCoroutine(ShowLine("YOU: I need to - hello? Hello?!"));
        yield return new WaitForSeconds(6.0f);
        currLine = "";

        StartCoroutine(ShowLine("YOU: I...I can't talk or move..."));
        yield return new WaitForSeconds(6.0f);
        currLine = "";

        StartCoroutine(ShowLine("NURSE: We have a code R40.2"));
        yield return new WaitForSeconds(6.0f);
        currLine = "";

        StartCoroutine(ShowLine("YOU: I'm in a coma...I need to get out of here!"));
        yield return new WaitForSeconds(8.0f);
        currLine = "";

        StartCoroutine(ShowLine("YOU: But first I need to remember who betrayed us..."));
        yield return new WaitForSeconds(6.0f);
        currLine = "";
        continueButton.SetActive(true);
    }

    IEnumerator ShowLine(string line)
    {
        currLine = "";
        for (int i = 0; i < line.Length+1; i++)
        {
            currLine = line.Substring(0,i);
            this.GetComponent<Text>().text = currLine;
            yield return new WaitForSeconds(delay);
        }
    }
}
