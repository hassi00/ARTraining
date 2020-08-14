using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPrefabGenerator : MonoBehaviour
{
    private Vector3 measurePrefabPods;
    public GameObject StarPrefab;

    public void OnStopMesure()
    {
        measurePrefabPods = StretchPositionController.measureObject.transform.position;
        measurePrefabPods.y = measurePrefabPods.y + 0.05f;
        Instantiate(StarPrefab, measurePrefabPods, Quaternion.identity);
    }
}
