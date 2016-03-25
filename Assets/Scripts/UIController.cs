using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    Image strongShotGage_;
    [SerializeField]
    PlayerShot playerShot_;

    float maxGage_;
    int maxFlame_;
    float gageHeight_;

    float gageValue_ = 0;

    //取得しとけば少しは軽くなるんじゃね？
    void Start()
    {
        maxGage_ = strongShotGage_.rectTransform.sizeDelta.x;
        gageHeight_ = strongShotGage_.rectTransform.sizeDelta.y;
        maxFlame_ = playerShot_.MaxStrongShotFlame;
	}

    //UIのゲージの反映
	void Update()
    {
        gageValue_ = ((float)playerShot_.GageValue / maxFlame_) * maxGage_;

        strongShotGage_.rectTransform.sizeDelta = new Vector2(gageValue_, gageHeight_);
	}
}
