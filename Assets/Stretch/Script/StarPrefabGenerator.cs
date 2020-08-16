using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPrefabGenerator : MonoBehaviour
{
    private Vector3 measurePrefabPods;
    public GameObject StarPrefab;

    //距離を測定終了時
    public void OnStopMesure()
    {
        //距離表示するバーの上に星を表示
        measurePrefabPods = StretchPositionController.measureObject.transform.position;
        measurePrefabPods.y = measurePrefabPods.y + 0.05f;
        Instantiate(StarPrefab, measurePrefabPods, Quaternion.identity);
    }
}
