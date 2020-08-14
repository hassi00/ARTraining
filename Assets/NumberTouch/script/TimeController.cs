using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{

    private float time_tmp;
    public static int time_s;
    private bool startTimeFlag;

    // Start is called before the first frame update
    public void StartTime()
    {
        startTimeFlag = true;
    }

    void Update()
    {
        if (startTimeFlag && TouchController.number < 10)
        {
            Debug.Log("Timeカウント");
            time_tmp += Time.deltaTime;
            time_s = Mathf.FloorToInt(time_tmp);
            GameObject.Find("Canvas").transform.GetChild(3).GetChild(2).GetComponent<Text>().text =
                time_s.ToString();
        }
    }
}
