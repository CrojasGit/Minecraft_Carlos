using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.transform.position=new Vector3(this.transform.position.x+(float)Math.Sin(Time.time)*0.1f,this.transform.position.y,this.transform.position.z);
    }
}
