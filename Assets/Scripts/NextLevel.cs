using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    public GameObject player;
    private bool _isInTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("end marker trigger enter");
        if (other.tag == "Player")
        {
            _isInTrigger = true;
        }
        // if (other.tag == "Player")
        // {
        //     GameObject player = GameObject.FindWithTag("Player");
        //     player.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isInTrigger) {
            if (player.transform.position.y < 6) {
                Debug.Log("player pos: " + player.transform.position);
                player.GetComponent<Rigidbody>().velocity = transform.up*speed;
            } else {
                _isInTrigger = false;
            }
        }
    }
}
