using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//時間のカウント
public class TimeController : MonoBehaviour
{
    
    private float time_tmp;
    public static int time_s;
    private bool startTimeFlag;

    // Start is called before the first frame update
    //スタート押下時
    public void StartTime()
    {
        startTimeFlag = true;
    }

    //時間をカウント
    void Update()
    {
        //スタートかつ９までタッチされるまでカウント
        if (startTimeFlag && TouchController.number < 10)
        {
            //Debug.Log("Timeカウント");
            time_tmp += Time.deltaTime;
            time_s = Mathf.FloorToInt(time_tmp);
            GameObject.Find("Canvas").transform.GetChild(3).GetChild(2).GetComponent<Text>().text =
                time_s.ToString();
        }
    }
}
