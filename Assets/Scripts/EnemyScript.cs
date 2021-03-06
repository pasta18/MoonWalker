﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    MoveScript moveScript_;
    [SerializeField]
    int hitpoint_ = 3;
    [SerializeField]
    int AddPoint = 10;

    bool Reversal = false;

    [SerializeField]
    float Speed_ = 2f;
    [SerializeField]
    float ReversalSpeed_ = 4f;

    Vector2 ReverseValue = new Vector2(0, 180);

	void Update()
    {
        Move();
	}

    // 向いている方向に向かって進む
    void Move()
    {
        if (Reversal)
        {
            moveScript_.Move(ReversalSpeed_);
        }
        else
        {
            moveScript_.Move(Speed_);
        }
    }

    // 反転する
    public void Reverse()
    {
        gameObject.transform.Rotate(ReverseValue);

        Reversal = !Reversal;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag == "Bullet")
        {
            Damage(col.gameObject);

            Destroy(col.gameObject);
        }
    }

    // 弾に当たるとダメージを受ける
    void Damage(GameObject bullet)
    {
        hitpoint_ -= bullet.GetComponent<Bullet>().BulletPower;

        HitPointCheck();
    }

    // 死亡判定
    void HitPointCheck()
    {
        if (hitpoint_ <= 0)
        {
            Destroy(gameObject);

            PointController.Add(AddPoint);
        }
    }
}
