using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    // bullet prefab
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;

    // 弾丸発射点
    public Transform cube;

    // 弾丸の速度
    public float speed = 1000;
    // 反動の関数を追加
    private bool reaction;
    private bool reaction2;
    private bool reaction3;

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
            transform.Translate(-0.1f, 0.1f, 0);
            time += Time.deltaTime;
        }

           //反動の時間
        if (time > 0.05f)
        {
            reaction = false;
        }
        if (reaction2 == true)
        {
            //反動の追加
            gameObject.transform.Translate(-0.14f, 0, 0);
            time += Time.deltaTime;
        }
            //反動の時間
        if (time > 0.05f)
        {
            reaction2 = false;
        }
        if (reaction3 == true)
        {
            //反動の追加
            gameObject.transform.Translate(-0.1f, -0.1f, 0);
            time += Time.deltaTime;
        }
            //反動の時間
        if (time > 0.05f)
        {
            reaction3 = false;
        }
        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Z))
        {
            reaction = true;
            time = 0;
            
            Vector2 pos = transform.position;

            // 弾丸の複製
            GameObject bullets = Instantiate(bullet3) ;

            Vector2 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = cube.position;

            cube.GetComponent<Rigidbody2D>().AddForce(-force);      
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            reaction2 = true;
            time = 0;

            
            // 弾丸の複製
            GameObject bullets = Instantiate(bullet);

            Vector2 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = cube.position;

            
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            reaction3 = true;
            time = 0;
            

            // 弾丸の複製
            GameObject bullets = Instantiate(bullet2);

            Vector2 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = cube.position ;

            
        }
    }

}
