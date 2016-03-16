using UnityEngine;
using System.Collections;

public class PlayerLifeScript : MonoBehaviour
{
    public LifeScript lifeScript_;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag == "Enemy")
        {
            lifeScript_.Damage();

            Destroy(col.gameObject);
        }
    }
}
