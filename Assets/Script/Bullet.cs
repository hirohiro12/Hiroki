using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour

{
    public int speed=100;
    float time;
    void Update()
    {
        //弾の方向 
        this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        time += Time.deltaTime;
        if (time>1f)
        {
            Destroy(gameObject);
        }
    }
}