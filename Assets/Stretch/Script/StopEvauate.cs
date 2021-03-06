﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//星の表示処理
public class StopEvauate : MonoBehaviour
{
    float ChangeCollorSpan = 0;
    int changeStarInt = 0;
    public float spanDetermin = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //星の色を変える処理
    void Update()
    {
        if (changeStarInt + 1 <= StretchStarNumber())
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

    //距離によって星の数を決める
    private int StretchStarNumber()
    {
        int num = 0;

        if (MesurePrefabMove.distance_int >=60)
        {
            num = 3;
        }
        else if (MesurePrefabMove.distance_int >= 42 && MesurePrefabMove.distance_int < 60)
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
