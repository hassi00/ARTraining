using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//メニューに戻る処理
public class QuitController : MonoBehaviour
{
    public void MenueMove()
    {
        Application.LoadLevel("MenueScene");
    }
}
