using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookneedjump : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Ground"))
        {
            
        }
        else
        {
            
        }
        
        
    }
}
