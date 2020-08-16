using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボタンの表示処理
public class StretchButtonController : MonoBehaviour
{
    public static bool startFlag;

    //スタートボタン押下時
    private void Start()
    {
        //やり直すボタン押下時
        transform.GetChild(1).gameObject.SetActive(false);
        //スタートボタン
        transform.GetChild(2).gameObject.SetActive(false);
        //計測ストップボタン
        transform.GetChild(3).gameObject.SetActive(false);
    }

    //スタートポジションを決めるボタン押下時
    public void SetUp()
    {
        //スタートポジションを決めるボタン
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }

    //やり直すボタン押下時
    public void Delete()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);

        Destroy(StretchPositionController.distanceObject);
        Destroy(StretchPositionController.startPodsObject);
        Destroy(StretchPositionController.measureObject);
    }

    public void StartMesure()
    {
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        //計測ストップボタン
        transform.GetChild(3).gameObject.SetActive(true);
        startFlag = true;
    }

    //計測ストップ時
    public void StopMeasure()
    {
        transform.GetChild(3).gameObject.SetActive(false);
        startFlag = false;
    }

    //メニューに戻るボタン押下時
    public void quitStretch()
    {
        Application.LoadLevel("MenueScene");
    }

}
