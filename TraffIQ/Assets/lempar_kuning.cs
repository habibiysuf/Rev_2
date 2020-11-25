using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lempar_kuning : MonoBehaviour
{
    public Transform pos_lempar;

    void OnTriggerEnter(Collider other)
    {
        // rand = Random.Range(0, targetnya.Length);
        other.transform.position = pos_lempar.position;
        // other.transform.position.x = pos_lempar.transform.position.x;
    }
}
