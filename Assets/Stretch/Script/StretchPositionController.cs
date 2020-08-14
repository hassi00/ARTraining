using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchPositionController : MonoBehaviour
{

    public GameObject distancePrefab;
    public GameObject startPodsPrefab;
    public GameObject measurePrefab;
    public static GameObject startPodsObject;
    public static GameObject distanceObject;
    public static GameObject measureObject;

    private Vector3 distanceObjectPods;
    private Vector3 measurePods;

    public void DistanceCreate()
    {
        distanceObjectPods = Camera.main.transform.localPosition;
        measurePods = Camera.main.transform.localPosition;

        distanceObjectPods.y = Camera.main.transform.localPosition.y - 0.1f;
        measurePods.y = Camera.main.transform.localPosition.y - 0.05f;

        distanceObject =Instantiate(distancePrefab, distanceObjectPods + Camera.main.transform.forward * 1.15f,Camera.main.transform.rotation);
        startPodsObject = Instantiate(startPodsPrefab, measurePods + Camera.main.transform.forward * 0.15f, Quaternion.identity);
        measureObject = Instantiate(measurePrefab, measurePods + Camera.main.transform.forward * 0.15f, Camera.main.transform.rotation);
    }
}
