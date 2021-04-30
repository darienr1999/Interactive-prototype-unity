using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    public Text displayText;
    private string message;
    private float delay;
    private bool newMsg;

    // Start is called before the first frame update
    void Start()
    {
        message = "";
        delay = 10.0f;
        newMsg = false;
    }

    void Update()
    {
        if (newMsg)
        {
            newMsg = false;
            StartCoroutine(ShowMessage());
        }
    }

    public void SetDisplayMessage(string _message, float _delay)
    {
        message = _message;
        delay = _delay;
        Debug.Log("Displaying message: " + message);
        newMsg = true;
    }

    IEnumerator ShowMessage()
    {
        displayText.text = message;
        yield return new WaitForSeconds(delay);
        displayText.text = "";
        message = "";
    }
}
