using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//星の色を変える
public class ChangeColloor : MonoBehaviour
{
    //次の星の色を変える時間
    float ChangeCollorSpan = 0;
    //色を変える数
    int changeStarInt = 0;

    //変える星の番号
    public  float spanDetermin = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (changeStarInt + 1 <= StarNumber())
        {
            if (ChangeCollorSpan >= spanDetermin)
            {
                this.transform.GetChild(changeStarInt).GetChild(0).gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.yellow;
                changeStarInt++;
                ChangeCollorSpan = 0;
            }
            ChangeCollorSpan += Time.deltaTime;
        }
        
    }

    //クリア時間によって星の数を決める
    private int StarNumber()
    {
        int num = 0;

        if (TimeController.time_s <= 20)
        {
            num = 3;
        }else if(TimeController.time_s > 20 && TimeController.time_s <= 40)
        {
            num = 2;
        }
        else
        {
            num = 1;
        }
            return num;
        
    }
}
