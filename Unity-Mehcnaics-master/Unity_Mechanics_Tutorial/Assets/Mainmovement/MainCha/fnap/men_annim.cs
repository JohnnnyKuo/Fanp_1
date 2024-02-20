using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class men_annim : MonoBehaviour
{
        private Animator ani ;
    // Start is called before the first frame update
    void Start()
    {
            ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetBool("IsRunning",false);
        if (Input.GetKey (KeyCode.A)){
            ani.SetBool("IsRunning",true);
        }
        
        if (Input.GetKey (KeyCode.D))
        {
            ani.SetBool("IsRunning",true);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ani.SetBool("IsJumping",true);
        }
 
 
 
    }
    private void OnTriggerEnter2D(Collider2D other) {
                ani.SetBool("IsJumping",false);
    }
}
