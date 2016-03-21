using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    [SerializeField]
    JumpScript jumpScript_;
    [SerializeField]
    PlayerShot playerShot_;
    
	void Start () 
    {
        
	}
	
	void Update () 
    {
        InputCheck();	
	}

    //入力に対する処理の振り分け
    void InputCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();

     /* if (Input.GetKey(KeyCode.Z))      */ Shot();
    }

    //プレイヤーのジャンプ処理を差別化
    void Jump()
    {
        jumpScript_.Jump();
    }

    //ショット時の動作
    void Shot()
    {
        playerShot_.Shot();
    }
}
