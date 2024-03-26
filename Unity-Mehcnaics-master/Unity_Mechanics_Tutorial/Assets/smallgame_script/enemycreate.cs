using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycreate : MonoBehaviour
{
    public int create_count;
    public float xpoint;
    public GameObject bird1,bird2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        for(int i=0;i<=create_count;i++)
        {
            Instantiate(bird1,new Vector3(xpoint,Random.Range(-37f,38f),0), transform.rotation);
        }
        
    }
}
