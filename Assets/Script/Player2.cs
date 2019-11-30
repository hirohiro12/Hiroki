using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // 速度
    public Vector2 SPEED = new Vector2(1.0f, 1.0f);
    Quaternion quaternion;


    void Start()
    {
        Quaternion quaternion = this.transform.rotation;
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
       
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left"))
        {
            //代入したPositionに対して加算減算を行う
            //Position.x -= SPEED.x;

            //物体の左回転
            transform.Rotate(new Vector3(0, 0, 1), 3);
        }
        
        if (Input.GetKey("right"))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
          // Position.x += SPEED.x;

            //物体の右回転
            transform.Rotate(new Vector3(0, 0, 1), -3);
        }
       
        if (Input.GetKey("up"))
        { // 上キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
          // Position.y += SPEED.y;
            transform.Rotate(new Vector3(0, 1, 0), -3);

        }
      
        if (Input.GetKey("down"))
        { // 下キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
          //  Position.y -= SPEED.y;
        }
        if(quaternion.eulerAngles.z== 90.0)
        {
            transform.Rotate(new Vector3(1, 0, 0), 90);
        }
       
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }


}
