using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//各ボタンの処理
public class SceneMove : MonoBehaviour
{
    //スクワット押下時
    public void SquatScene()
    {
        Application.LoadLevel("SquatScene");
    }

    //ナンバータッチ押下時
    public void NumberTouchScene()
    {
        Application.LoadLevel("NumberTouch");
    }

    //ストレッチ押下時
    public void StretchScene()
    {
        Application.LoadLevel("Stretch");
    }
}
