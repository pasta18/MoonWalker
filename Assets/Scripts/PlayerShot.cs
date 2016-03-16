using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{
    public ShotScript shotScript_;

    public int ShotInterval_ = 15;
    int autoshotcount_ = 0;

    public int MAXSHOTCOUNT = 2; //n+1回に１回強い弾出る
    int shotcount_ = 0;

    public int MAXNOTINPUTKEY = 180;
    int notinputkeycount_ = 0;

    bool strongshotflag = false;

    //UIのゲージ増加量設定に使用
    public int MaxStrongShotFlame
    {
        get
        {
            return MAXNOTINPUTKEY;
        }
    }

    //UIへのゲージ反映に使用
    public int GageValue
    {
        get
        {
            return notinputkeycount_;
        }
    }

    //ショット時の動作
    public void Shot()
    {
        NotInputButtonSet();

        if (!InputShotButton()) return;

        SetStrongShot();

        if (ShotPossible()) KeepButtonStrongShot();

        ShotIntervalCount();
    }

    //押しっぱなしかどうか判定
    bool InputShotButton()
    {
        if (Input.GetKey(KeyCode.Z)) return true;
        else
        {
            ShotIntervalCountReset();

            RemoveStrongShotFlag();

            shotcount_ = 0;

            return false;
        }
    }

    //ショット押しっぱなしのときに使う
    void ShotIntervalCount()
    {
        autoshotcount_++;

        if (autoshotcount_ > ShotInterval_) ShotIntervalCountReset();
    }

    //強い弾を出せるようにする
    void SetStrongShot()
    {
        if (shotcount_ >= MAXSHOTCOUNT)
        {
            strongshotflag = true;
        }
    }

    //押しっぱなしなら３回に１回強い弾
    void KeepButtonStrongShot()
    {
        if(strongshotflag)
        {
            shotScript_.StrongShot();

            strongshotflag = false;

            shotcount_ = 0;
        }
        else
        {
            shotScript_.Shot();

            shotcount_++;
        }
    }

    //押しっぱなしのときは一定間隔で撃つ
    bool ShotPossible()
    {
        return autoshotcount_ == 0;
    }

    //押しっぱなしでなければクールダウンいらない
    void ShotIntervalCountReset()
    {
        autoshotcount_ = 0;
    }

    //ボタン放したら強い弾を解除
    void RemoveStrongShotFlag()
    {
        if (shotcount_ >= MAXSHOTCOUNT) strongshotflag = false;
    }

    //一定時間ボタンを押さないと強い弾がセットされる
    void NotInputButtonSet()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            notinputkeycount_ = 0;
        }
        else
        {
            if (strongshotflag) return;

            if (notinputkeycount_ > MAXNOTINPUTKEY) strongshotflag = true;

            notinputkeycount_++;
        }
    }
}
