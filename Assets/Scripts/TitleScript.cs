using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleScript : MonoBehaviour
{
    [SerializeField]
    GameObject StartIcon_;
    [SerializeField]
    GameObject ExitIcon_;

    bool select_start_ = true;

	void Update()
    {
        // タイトル画面の操作
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

    // タイトルで選択しているメニューの可視化
    void ChangeSelectIcon()
    {
        StartIcon_.SetActive(!StartIcon_.activeSelf);

        ExitIcon_.SetActive(!ExitIcon_.activeSelf);
    }

    // 画面推移
    void ChangeScene()
    {
        if (select_start_)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Application.Quit();
        }
    }
}
