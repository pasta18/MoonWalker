using UnityEngine;
using System.Collections;

public class LifeScript : MonoBehaviour
{
    int MAXLIFE = 3;
    int life;

    [SerializeField]
    GameObject[] LifeIcon;

    [SerializeField]
    string GameEndScene;

	void Start()
    {
        life = MAXLIFE;
	}

    public void Damage()
    {
        if (life > 0)
        {
            life--;

            LifeIcon[life].SetActive(false);
        }
        else
        {
            //GameOverの処理を書く
            Application.LoadLevel(GameEndScene);
        }
    }
}
