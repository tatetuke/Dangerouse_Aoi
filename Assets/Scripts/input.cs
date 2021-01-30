using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public static bool isLeft;
    public static bool isRight;
    public static bool isUp;
    public static bool isDown;
    public static bool isReverse;

    public void Start()
    {
    }

    public void Update()
    {
        //カーソル左、右、上、下、スペースが押されることで下記フラグがtrueになる
        isLeft = false;
        isRight = false;
        isUp = false;
        isDown = false;
        isReverse = false;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isLeft = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            isUp = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            isDown = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isReverse = true;
        }
    }
}
