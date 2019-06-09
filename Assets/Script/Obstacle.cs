using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            manager.GameOver();
            manager.Dead = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            manager.GameOver();
            manager.Dead = true;
        }
    }
}
