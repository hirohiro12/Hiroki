using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 速度
    public bool boost;
    public bool boost2;
    public bool boost3;
    public bool boost4;
    public Vector2 SPEED = new Vector2(1.0f, 1.0f);
    float time = 0f;
    // Use this for initialization
    void Start()
    {
        boost = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 移動処理
        Move();
    }

    // 移動関数
    void Move()
    {
        if (boost == true)
        {
            transform.Translate(-0.15f, 0, 0);
            time += Time.deltaTime;
        }
        if (time > 0.40f)
        {
            boost = false;
        }
        if (boost2 == true)
        {
            transform.Translate(0.15f, 0, 0);
            time += Time.deltaTime;
        }
        if (time > 0.40f)
        {
            boost2 = false;
        }
        if (boost3 == true)
        {
            transform.Translate(0, 0.15f, 0);
            time += Time.deltaTime;
        }
        if (time > 0.40f)
        {
            boost3 = false;
        }
        if (boost4 == true)
        {
            transform.Translate(0, -0.15f, 0);
            time += Time.deltaTime;
        }
        if (time > 0.40f)
        {
            boost4 = false;
        }
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left"))
        {
            //代入したPositionに対して加算減算を行う
            //Position.x -= SPEED.x;
           
            //物体の左回転
            transform.Rotate(new Vector3(0, 0,1), 3);
        }
        if (Input.GetKey("left")&& Input.GetKey("left shift"))
        {
            boost = true;
            time = 0;
        }
         if (Input.GetKey("right"))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
          // Position.x += SPEED.x;
          
            //物体の右回転
            transform.Rotate(new Vector3(0, 0, 1), -3);
        }
        if (Input.GetKey("right") && Input.GetKey("left shift"))
        {
            boost2 = true;
            time = 0;
        }
        if (Input.GetKey("up"))
        { // 上キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            Position.y += SPEED.y;
         
            
        }
        if (Input.GetKey("up") && Input.GetKey("left shift"))
        {
            boost3 = true;
            time = 0;
        }
        if (Input.GetKey("down"))
        { // 下キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            Position.y -= SPEED.y;
        }
        if (Input.GetKey("down") && Input.GetKey("left shift"))
        {
            boost4 = true;
            time = 0;
        }
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }


}
