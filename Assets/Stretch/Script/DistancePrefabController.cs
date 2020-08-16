using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//距離を表示（３Dテキスト）
public class DistancePrefabController : MonoBehaviour
{
    // Start is called before the first frame update
    //20~80cmの３Dテキストを非表示
    void Start()
    {
        for (int i = 1; i <= 7; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

    }

    //距離によって３Dテキストを表示
    // Update is called once per frame
    void Update()
    {
        if (MesurePrefabMove.distance_int <= 10)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (MesurePrefabMove.distance_int <= 20)
        {
            transform.GetChild(2).gameObject.SetActive(true);
            //transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (MesurePrefabMove.distance_int <= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (MesurePrefabMove.distance_int <= 40)
        {
            transform.GetChild(4).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (MesurePrefabMove.distance_int <= 50)
        {
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
        }
        else if (MesurePrefabMove.distance_int <= 60)
        {
            transform.GetChild(6).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (MesurePrefabMove.distance_int <= 70)
        {
            transform.GetChild(7).gameObject.SetActive(true);
            transform.GetChild(4).gameObject.SetActive(false);
        }
    }
}