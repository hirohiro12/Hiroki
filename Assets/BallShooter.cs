using UnityEngine;

public class BallShooter : MonoBehaviour
{

    public GameObject ball;
    float speed;
    public bool reaction;
    float time = 0f;

    void Start()
    {
        reaction = false;
        speed = 30.0f;  // 弾の速度
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

            // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 向きの生成（Z成分の除去と正規化）
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;
            Vector3 PlayerForward = Vector3.Scale(-(mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;
            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

            reaction = true;
            time = 0;

            if (reaction == true)
            {
                //反動の追加
             
                time += Time.deltaTime;
            }
            if (time > 0.5f)
            {
                reaction = false;
            }
        }
       
    }
}        

