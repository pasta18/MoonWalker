using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab_;
    [SerializeField]
    SpawnController spawnController_;

    public void SpawnLeft()
    {
        spawnController_.SpawnLeft(enemyPrefab_);
    }

    public void SpawnRight()
    {
        GameObject enemy = spawnController_.SpawnRight(enemyPrefab_);

        enemy.GetComponent<EnemyScript>().Reverse();
    }
}
