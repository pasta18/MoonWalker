﻿using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour
{
    [SerializeField]
    GameObject spawnPointRight_;
    [SerializeField]
    GameObject spawnPointLeft_;

    float spawnPointRightX_;
    float spawnPointLeftX_;

    // 変化しない値なのであらかじめ取得しておく
    void Start()
    {
        spawnPointRightX_ = spawnPointRight_.transform.position.x;
        spawnPointLeftX_ = spawnPointLeft_.transform.position.x;
	}

    //向きとか調整するためにオブジェクトを返す
    public GameObject SpawnLeft(GameObject spawnObject)
    {
        return (GameObject)Instantiate(
                        spawnObject, 
                        new Vector2(spawnPointLeftX_, spawnObject.transform.position.y), 
                        Quaternion.identity
                    );
    }

    public GameObject SpawnRight(GameObject spawnObject)
    {
        return (GameObject)Instantiate(
                        spawnObject,
                        new Vector2(spawnPointRightX_, spawnObject.transform.position.y),
                        Quaternion.identity
                    );
    }
}
