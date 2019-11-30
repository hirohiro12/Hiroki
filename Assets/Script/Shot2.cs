using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot2 : MonoBehaviour
{

    // bullet prefab
    public GameObject bullet;
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
        if (Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown("joystick button 2"))
        {
            reaction = true;
            time = 0;


            // 弾丸の複製
            GameObject bullets = Instantiate(bullet);

            Vector2 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            // 弾丸の位置を調整           
            bullets.transform.rotation = cube.rotation;
            bullets.transform.position = cube.position;
            cube.GetComponent<Rigidbody2D>().AddForce(-force);
        }
    }
}