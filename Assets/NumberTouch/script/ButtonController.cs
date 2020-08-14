using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject NumberPrefab;
    Vector3 NumberPosition = new Vector3(0,0,0);
    private GameObject NumberTemp;
    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void DisplayButton()
    {

        NumberPosition = Camera.main.transform.localPosition + Camera.main.transform.forward * 1.5f;
        NumberTemp = Instantiate(NumberPrefab, NumberPosition, Camera.main.transform.localRotation);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }

    public void DeleteButton()
    {
        Destroy(NumberTemp);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void StartNumberTouch()
    {
        ObjectShuffle();
        for (int i = 0; i < 9; i++)
        {
            NumberTemp.transform.GetChild(i).GetChild(0).GetComponent<TextMesh>().text = numberArray[i].ToString();
        }

        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }


    void ObjectShuffle()
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            int tmp = numberArray[i];
            int randomIndex = Random.Range(i, numberArray.Length);
            numberArray[i] = numberArray[randomIndex];
            numberArray[randomIndex] = tmp;
        }
    }

    public void MenueBotton()
    {
        Application.LoadLevel("MenueScene");
    }
}
