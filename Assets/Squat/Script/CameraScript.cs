using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


//カメラのポジションを取得するクラス
public class CameraScript : MonoBehaviour
{

    private Vector3 cameraPosition;
    private Vector3 startPosition;
    

    // カメラのy座標を取得
    void Update()
    {
        cameraPosition.y =Camera.main.transform.position.y;
        
    }


    //カメラのポジションを取得
    Vector3 getStartPosition()
    {
        return Camera.main.transform.position;
    }
}
