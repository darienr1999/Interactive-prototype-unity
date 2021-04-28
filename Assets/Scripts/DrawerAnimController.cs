using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimController : MonoBehaviour
{
    public Animator animator;
    private bool _isInTrigger = false;
    private bool _isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInTrigger = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player");
        {
            _isInTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isInTrigger) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isOpen = !_isOpen;
                animator.SetBool("open", _isOpen);
            }
        }

    }
}
