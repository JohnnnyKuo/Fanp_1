using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = new Vector2(target.position.x, target.position.y );
            transform.position = newPosition;
        }
    }

}
