using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//スクワットの回数をカウントするクラス
public class SquatCountor : MonoBehaviour
{
    //カウントを開始する変数
    private bool countFlag = false;

    //カウント用変数
    int countNumberMain;

    //カウントした数字を表示するためのオブジェクト
    GameObject textObj;

    //カウントを開始する変数
    private static bool startFlag = false;

    public GameObject ErrMSG;
    // Start is called before the first frame update
    void Start()
    {
        countFlag = true;
        textObj = GameObject.Find("countText");
    }

    //スタートボタンを押した時にフラグを立てる
    public void StartCount()
    {
        startFlag = true;
        //Debug.Log(startFlag);
    }

    //カメラのポジションがカウントラインに達したらカウント
    void Update()
    {
        //Debug.Log(startFlag + "Update");
        if (startFlag)
        {
            //Debug.Log("startFlag=true");
            if (Camera.main.transform.position.y > transform.position.y && countFlag)
            {
                countNumberMain++;
                textObj.GetComponent<Text>().text = countNumberMain.ToString();
                countFlag = false;
            }
            else if (Camera.main.transform.position.y < transform.position.y)
            {
                countFlag = true;
            }
        }
    }
    



}
