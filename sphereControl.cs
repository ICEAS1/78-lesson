using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="good"){
        rb.AddForce(0,200f,0);
        }
        if(col.gameObject.tag=="bad"){
            print("bad");
        }
    }
    void OnMouseDown(){
        Destroy(gameObject);
    }
}
