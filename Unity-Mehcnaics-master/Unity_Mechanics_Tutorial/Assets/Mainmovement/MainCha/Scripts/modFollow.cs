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
            // 设置 follower 的位置为目标物体的位置
            Vector3 newPosition = new Vector2(target.position.x, target.position.y );
            transform.position = newPosition;
        }
    }

}
