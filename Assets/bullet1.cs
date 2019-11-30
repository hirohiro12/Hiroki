using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelItem : MonoBehaviour
{
    public Player Player;
    float time;
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")||time>1.0)//tag:Playerと接触した時の判定
        {
            Player.
            Destroy(gameObject);//オブジェクト削除
            //Debug.Log("!");
        }
    }

}