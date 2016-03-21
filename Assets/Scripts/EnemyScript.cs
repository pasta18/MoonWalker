using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    MoveScript moveScript_;
    [SerializeField]
    int hitpoint_ = 3;

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

    public void Reverse()
    {
        gameObject.transform.Rotate(ReverseValue);

        Reversal = true;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag == "Bullet")
        {
            Damage(col.gameObject);

            Destroy(col.gameObject);
        }
    }

    void Damage(GameObject bullet)
    {
        hitpoint_ -= bullet.GetComponent<Bullet>().BulletPower;

        HitPointCheck();
    }

    void HitPointCheck()
    {
        if (hitpoint_ <= 0) Destroy(gameObject);
    }
}
