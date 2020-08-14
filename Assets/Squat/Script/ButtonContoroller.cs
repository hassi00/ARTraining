using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonContoroller : MonoBehaviour
{

    private void Start()
    {
        transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void Bottondecide()
    {
        //0:create,1:delete,2:decide,3:quit
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(true);
    }

    public void DecideBottonCreate()
    {
        transform.GetChild(2).gameObject.SetActive(true);
    }

    public void Delete()
    {
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void StopSquat()
    {
        Application.LoadLevel("MenueScene");
    }

}
