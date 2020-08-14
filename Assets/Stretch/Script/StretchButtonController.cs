using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchButtonController : MonoBehaviour
{
    public static bool startFlag;

    private void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
    }
    public void SetUp()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }

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
        transform.GetChild(3).gameObject.SetActive(true);
        startFlag = true;
    }

    public void StopMeasure()
    {
        transform.GetChild(3).gameObject.SetActive(false);
        startFlag = false;
    }

    public void quitStretch()
    {
        Application.LoadLevel("MenueScene");
    }

}
