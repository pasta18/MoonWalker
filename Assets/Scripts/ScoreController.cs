using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    Text Score;
    // Textの更新を最低限に
    int score = 0;

    void Start()
    {
        Score.text = "SCORE:" + score;
    }

	void Update ()
    {
        // UIのTextの更新
	    if(PointController.Point != score)
        {
            score = PointController.Point;

            Score.text = "SCORE:" + score;
        }
	}
}
