﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackY : MonoBehaviour
{
   // Start is called before the first frame update
    public Vector3 trac;
    public static bool chek = false;
    public bool chekk = false;
    private Vector3 awal;
    void Start()
    {
        this.transform.position = GetComponentInParent<Transform>().position;
       
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3 (3,0,0);
        //this.transform.position += cek.x;
        //this.transform.position = GetComponentInParent<Transform>().position;
        this.transform.localPosition = cek.x - a;
    }
    
    void OnTriggerEnter(Collider other) {        
        chekk = true;
        if (other.gameObject.tag == "wall_y")
        {
            chek = true;
        }      
        else 
        {          
            return ;
        }

    }
    void OnTriggerExit(Collider other) {
        chekk = false;
        if (other.gameObject.tag == "wall_y")
        {
            chek = false;
        }      
        else 
        {          
            return ;
        }
    }
}
