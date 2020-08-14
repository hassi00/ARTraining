using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    public Material material;
    public GameObject StarPrefab;
    public GameObject TimeText;
    public Vector3 NumbersPosition;

    public static int number = 1;

    
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("衝突" + other.transform.GetChild(0).GetComponent<TextMesh>().text
            //.Equals(number.ToString()));

        if(number<10 && other.transform.GetChild(0).GetComponent<TextMesh>().text
            .Equals(number.ToString()))
        {
            //Debug.Log("判定通過," + number);
            other.transform.GetComponent<Renderer>().material = material;
            number++;

            if (TouchController.number >= 10)
            {
                NumbersPosition = other.transform.parent.position;
                Destroy(other.transform.parent.gameObject);
                Invoke("ClearTraining", 2.0f);

            }
            //Debug.Log("判定通過2," + number);

        }
    }

    void ClearTraining()
    {
        Instantiate(StarPrefab, NumbersPosition,Quaternion.identity);
    }

    void Start()
    {


    }



}
