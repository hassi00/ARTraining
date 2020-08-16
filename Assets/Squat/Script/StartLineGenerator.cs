using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//カウントラインを生成するクラス
public class StartLineGenerator : MonoBehaviour
{
    private Vector3 startPosition = new Vector3(0,0,0);

    //カウントラインのプレファブ用変数
    public GameObject StartLinePrefab;
    private GameObject startLine;

    private bool startLineNotGenerated = true;

    //カウントラインを生成
    public　void StartPositioncreate()
    {
        if (startLineNotGenerated)
        {
            //カウントラインを生成
            startLine =Instantiate(StartLinePrefab,  GetStartPosition(), GetStartRotation());
            //カウントラインを生成したらフラグをfalseに
            startLineNotGenerated = false;
        }
    }

    //やり直すボタンを押した時にカウントラインを消してフラグを立てる
    public void StartLineDelete()
    {
        Destroy(startLine);
        startLineNotGenerated = true;
    }

    //カウントラインの位置を決めるメソッド
    Vector3 GetStartPosition()
    {
        return Camera.main.transform.position + Camera.main.transform.forward;
    }
    //カウントラインの向きを決める
    Quaternion GetStartRotation()
    {
        return Camera.main.transform.rotation;
    }


}
