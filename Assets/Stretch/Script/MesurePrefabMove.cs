using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カメラでバーを押した時の処理
public class MesurePrefabMove : MonoBehaviour
{

    private bool OnMesureFlag;
    private Vector3 MesurePodsTMP;
    private float distance_m;
    public static int distance_int;

    private void OnTriggerEnter(Collider other)
    {
        //OnMesureFlag = true;
    }
    //カメラと距離の表示バーが接触している間
    private void OnTriggerStay(Collider other)
    {
        if (StretchButtonController.startFlag && other.tag == "MainCamera")
        {
            //距離表示バーを移動させる
            MesurePodsTMP = transform.localPosition;
            MesurePodsTMP = MesurePodsTMP + transform.forward * 0.01f;

            transform.localPosition = MesurePodsTMP;
        }
    }

    //距離の表示制御
     void Update()
    {
        if (StretchButtonController.startFlag)
        {
            distance_m = transform.localPosition.z - StretchPositionController.startPodsObject.transform.localPosition.z;
            //メートルをcmに変換
            distance_m *= 100;
            distance_int = (int)distance_m;
            StretchPositionController.measureObject.transform.GetChild(0).GetComponent<TextMesh>().text = distance_int.ToString() + "cm";
        }
    }
}
