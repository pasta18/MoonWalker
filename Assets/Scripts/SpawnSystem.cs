using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField]
    EnemySpawnController spawnController;
    [SerializeField]
    int CoolDownRight = 600;
    [SerializeField]
    int CoolDownLeft = 60;
    [SerializeField]
    int LeftSpawnProbability = 50;
    [SerializeField]
    int RightSpawnProbability = 70;

    int coolDownL = 0;
    int coolDownR = 0;

	void Update()
    {
        if (coolDownL < CoolDownLeft)
        {
            coolDownL++;
        }
        else
        {
            var randomL = Random.Range(0, 100);

            if (randomL > LeftSpawnProbability)
            {
                SpawnLeft();       
            }

            coolDownL = 0;
        }

        if(coolDownR < CoolDownRight)
        {
            coolDownR++;          
        }
        else
        {
            var randomR = Random.Range(0, 100);

            if (randomR > RightSpawnProbability)
            {
                SpawnRight();

                coolDownR = 0;
            }
            else
            {
                coolDownR = 540;
            }
        }
	}

    void SpawnLeft()
    {
        spawnController.SpawnLeft();
    }

    void SpawnRight()
    {
        spawnController.SpawnRight();
    }
}
