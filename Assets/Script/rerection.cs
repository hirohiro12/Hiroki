using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rerection : MonoBehaviour
{

    // bullet prefab
    // 弾丸発射点
    public Transform cube;

    // 弾丸の速度
    public float speed = 10;
    // 反動の関数を追加
    private bool reaction;
    float time = 0f;
    // Use this for initialization
    void Start()
    {
        reaction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (reaction == true)
        {
            //反動の追加
            this.transform.Translate(Vector3.right * Time.deltaTime * -speed);
            time += Time.deltaTime;
        }

        //反動の時間
        if (time > 0.5f)
        {
            reaction = false;
        }
        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Z))
        {
            reaction = true;
            time = 0;



            Vector2 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            cube.GetComponent<Rigidbody2D>().AddForce(-force);
        }
    }
}