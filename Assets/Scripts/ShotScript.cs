using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour
{
    [SerializeField]
    GameObject BulletPrefab_;
    [SerializeField]
    GameObject StrongBulletPrefab_;

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
