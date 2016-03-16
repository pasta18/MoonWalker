using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour
{
    public GameObject StartIcon_;
    public GameObject ExitIcon_;

    bool select_start_ = true;

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ChangeScene();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            select_start_ = !select_start_;

            ChangeSelectIcon();
        }
	}

    void ChangeSelectIcon()
    {
        StartIcon_.SetActive(!StartIcon_.activeSelf);

        ExitIcon_.SetActive(!ExitIcon_.activeSelf);
    }

    void ChangeScene()
    {
        if (select_start_)
        {
            Application.LoadLevel("GameScene");
        }
        else
        {
            Application.Quit();
        }
    }
}
