using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    void Update()
    {
        //弾の方向 
        transform.Translate(0.4f, 0.4f, 0);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}