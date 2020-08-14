using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CameraScript : MonoBehaviour
{

    private Vector3 cameraPosition;
    private Vector3 startPosition;
    

    // Update is called once per frame
    void Update()
    {
        cameraPosition.y =Camera.main.transform.position.y;
        
    }

    Vector3 getStartPosition()
    {
        return Camera.main.transform.position;
    }
}
