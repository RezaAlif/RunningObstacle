using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {

    public Transform Coll;
    bool Nemu;
    bool Bawa;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 10);

        RaycastHit rayHit;
        if (Physics.Raycast(Coll.position, transform.forward, out rayHit))
        {
            if (rayHit.collider.tag == "Stuff")
            {
                Nemu = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && Nemu == true)
        {
            Bawa = true;
        }
    }

    public void Equip()
    {
        if(Bawa == true)
        {

        }
    }
}
