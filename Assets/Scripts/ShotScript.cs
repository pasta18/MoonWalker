using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour
{
    public GameObject BulletPrefab_;
    public GameObject StrongBulletPrefab_;

    //弾の生成のみ
    public void Shot()
    {
        Instantiate(
                BulletPrefab_, 
                gameObject.transform.position,
                Quaternion.identity
            );
    }

    //威力の高い弾
    public void StrongShot() {
        Instantiate(
                StrongBulletPrefab_,
                gameObject.transform.position,
                Quaternion.identity
            );
    }
}
