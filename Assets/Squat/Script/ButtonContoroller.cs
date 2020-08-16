using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *ボタンの表示非表示の処理を行うクラス
 */
public class ButtonContoroller : MonoBehaviour
{

    private void Start()
    {
        //スタートボタンとやり直しボタン設定
        transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    /*
     * スタートボタンを押した時の処理
     *メニューに戻るボタンのみ表示
     */
    public void Bottondecide()
    {
        //0:create,1:delete,2:decide（スタート）,3:quit（メニューへ戻る）
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(true);
    }

    //スタートボタンの表示処理
    public void DecideBottonCreate()
    {
        transform.GetChild(2).gameObject.SetActive(true);
    }

    //やり直すボタンを押した時の処理
    //スタートボタンを削除する
    public void Delete()
    {
        transform.GetChild(2).gameObject.SetActive(false);
    }

    //メニューに戻るボタンの処理
    //メニューシーンへ移動
    public void StopSquat()
    {
        Application.LoadLevel("MenueScene");
    }

}
