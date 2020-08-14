using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquatCountor : MonoBehaviour
{

    private bool countFlag = false;

    int countNumberMain;
    GameObject textObj;
    private static bool startFlag = false;

    public GameObject ErrMSG;
    // Start is called before the first frame update
    void Start()
    {
        countFlag = true;
        textObj = GameObject.Find("countText");
    }

    public void StartCount()
    {
        startFlag = true;
        //Debug.Log(startFlag);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(startFlag + "Update");
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
