using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ボタンの表示、非表示の処理
public class ButtonController : MonoBehaviour
{
    //生成する数字のプレファブ
    public GameObject NumberPrefab;
    //生成する数字のポジション
    Vector3 NumberPosition = new Vector3(0,0,0);
    //生成したオブジェクトを格納する変数
    private GameObject NumberTemp;

    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    // Start is called before the first frame update
    //スタート、やり直しボタンを非表示
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    //数字を表示するボタン押下時
    public void DisplayButton()
    {
        //カメラの1.5m前のポジションを取得し生成
        NumberPosition = Camera.main.transform.localPosition + Camera.main.transform.forward * 1.5f;
        NumberTemp = Instantiate(NumberPrefab, NumberPosition, Camera.main.transform.localRotation);
        //数字を表示するボタンを非表示
        transform.GetChild(0).gameObject.SetActive(false);
        //スタートボタンとやり直しボタンを表示
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }

    //やり直しボタンを押下時
    public void DeleteButton()
    {
        //生成したオブジェクト（1〜９の数字）を削除
        Destroy(NumberTemp);
        //数字を表示するボタンを表示、スタートボタンとやり直しボタンを非表示
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    //スタートボタン押下時
    public void StartNumberTouch()
    {
        //配列をランダムにソート
        ObjectShuffle();

        //数字を書き換える
        for (int i = 0; i < 9; i++)
        {
            NumberTemp.transform.GetChild(i).GetChild(0).GetComponent<TextMesh>().text = numberArray[i].ToString();
        }
        //スタートボタンとやり直しボタンを非表示
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    //配列をランダムにソート
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

    //メニューに戻るボタン押下時
    public void MenueBotton()
    {
        Application.LoadLevel("MenueScene");
    }
}
