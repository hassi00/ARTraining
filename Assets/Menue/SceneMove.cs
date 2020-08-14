using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMove : MonoBehaviour
{
    public void SquatScene()
    {
        Application.LoadLevel("SquatScene");
    }

    public void NumberTouchScene()
    {
        Application.LoadLevel("NumberTouch");
    }

    public void StretchScene()
    {
        Application.LoadLevel("Stretch");
    }
}
