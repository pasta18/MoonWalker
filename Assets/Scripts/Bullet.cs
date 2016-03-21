using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float bulletspeed_ = 10f;
    [SerializeField]
    int bulletpower_ = 1;

    public int BulletPower
    {
        get
        {
            return bulletpower_;
        }
    }

	//通常弾は直進のみ
	void Update()
    {
        float speed = -bulletspeed_ * Time.deltaTime;

        gameObject.transform.Translate(new Vector3(speed, 0, 0));
	}
}
