using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLineGenerator : MonoBehaviour
{
    private Vector3 startPosition = new Vector3(0,0,0);
    public GameObject StartLinePrefab;
    private GameObject startLine;

    private bool startLineNotGenerated = true;


    public　void StartPositioncreate()
    {
        if (startLineNotGenerated)
        {
            startLine =Instantiate(StartLinePrefab,  GetStartPosition(), GetStartRotation());
            startLineNotGenerated = false;
        }
    }

    public void StartLineDelete()
    {
        Destroy(startLine);
        startLineNotGenerated = true;
    }

    Vector3 GetStartPosition()
    {
        return Camera.main.transform.position + Camera.main.transform.forward;
    }

    Quaternion GetStartRotation()
    {
        return Camera.main.transform.rotation;
    }


}
