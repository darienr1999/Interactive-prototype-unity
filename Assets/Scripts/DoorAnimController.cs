using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimController : MonoBehaviour
{
    public Animator animator;
    private bool isInTrigger;
    private bool isOpen;

    // Start is called before the first frame update
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
            Debug.Log("Player entered door");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = false;
            Debug.Log("Player exited door");
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
                Debug.Log("Player opened door: " + isOpen);

                if (this.GetComponent<AudioSource>())
                {
                    this.GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
