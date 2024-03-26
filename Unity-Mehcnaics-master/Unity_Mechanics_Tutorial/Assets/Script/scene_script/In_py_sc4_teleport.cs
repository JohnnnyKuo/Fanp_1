using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_py_sc4_teleport : MonoBehaviour
{
    public GameObject TeleportItem;
    public GameObject trapl,trapr;
    static public bool Item=false,in_py_trap=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        in_py_trap=true;
        trapl.SetActive(true);
        trapr.SetActive(true);
        TeleportItem.SetActive(false);
        Item=true;
    }
}
