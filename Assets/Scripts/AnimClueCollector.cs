using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimClueCollector : MonoBehaviour
{
    public Animator animator;
    public GameObject clue;
    public GameController gc;
    public DisplayMessage dm;
    public string msg;
    public float delay;
    private bool isInTrigger;
    private bool isOpen;

    void Start()
    {
        isInTrigger = false;
        isOpen = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = true;
            Debug.Log("Player entered drawer");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = false;
            Debug.Log("Player exited drawer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isOpen = !isOpen;
                animator.SetBool("open", isOpen);
                Debug.Log("Player opened drawer: " + isOpen);
                
                if (this.GetComponent<AudioSource>())
                {
                    this.GetComponent<AudioSource>().Play();
                }
                
                if (clue.activeSelf)
                {
                    gc.CollectClue();
                    dm.SetDisplayMessage(msg, delay);
                    StartCoroutine(DeactivateClue());
                }
            }
        }

    }

    IEnumerator DeactivateClue()
    {
        yield return new WaitForSeconds(3.0f);
        clue.SetActive(false);
    }
}
