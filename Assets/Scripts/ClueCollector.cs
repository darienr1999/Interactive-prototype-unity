using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueCollector : MonoBehaviour
{
    public GameObject clue;
    public GameController gc;
    public DisplayMessage dm;
    public string msg;
    public float delay;
    private bool isInTrigger;

    // Start is called before the first frame update
    void Start()
    {
        isInTrigger = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = true;
            Debug.Log("Player entered clue: " + clue.name);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = false;
            Debug.Log("Player exited clue: " + clue.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (clue.activeSelf)
                {
                    gc.CollectClue();
                    dm.SetDisplayMessage(msg, delay);
                    clue.SetActive(false);
                    
                    if (this.GetComponent<AudioSource>())
                    {
                        this.GetComponent<AudioSource>().Play();
                    }
                    // StartCoroutine(DeactivateClue());
                }
            }
        }

    }

    // IEnumerator DeactivateClue()
    // {
    //     yield return new WaitForSeconds(2.0f);
    //     clue.SetActive(false);
    // }
}
