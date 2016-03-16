using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float bulletspeed_ = 10f;
    public int bulletpower_ = 1;

	//通常弾は直進のみ
	void Update()
    {
        float speed = -bulletspeed_ * Time.deltaTime;

        gameObject.transform.Translate(new Vector3(speed, 0, 0));
	}
}
