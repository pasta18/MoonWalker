using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("TitleScene");
        }
	}
}
