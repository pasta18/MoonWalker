using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour 
{
    [SerializeField]
    float JumpPower_ = 600f;

    bool jumpflag_ = false;

    public void Jump()
    {
        //２段ジャンプ禁止
        if (JumpCheck()) return;

        Vector2 power = new Vector2(0, JumpPower_);

        gameObject.transform.GetComponent<Rigidbody2D>().AddForce(power);
    }

    public bool JumpCheck()
    {
        // trueを返すならジャンプしない
        if (jumpflag_)
        {
            return true;
        }
        else
        {
            jumpflag_ = true;

            return false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //ジャンプ状態を解除
        if (jumpflag_)
        {
            if (col.transform.tag == "Ground") jumpflag_ = false;
        }
    }
}
