using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shooting(GameObject Ammo)
    {
        GameObject m_Ammo = Instantiate(Ammo, transform.position, transform.rotation);
        m_Ammo.transform.Translate(Vector3.forward * 10);
    }
}
