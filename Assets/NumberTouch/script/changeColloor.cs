using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColloor : MonoBehaviour
{

    float ChangeCollorSpan = 0;
    int changeStarInt = 0;
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
