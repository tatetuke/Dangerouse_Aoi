using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
public class OnNextAndSubscribe : MonoBehaviour
{
    Subject<string> subject = new Subject<string>();
    /// <summary>暗転用黒テクスチャ</summary>
    private Texture2D blackTexture;
    // Start is called before the first frame update
    void Start()
    {
        subject.Subscribe(msg => Debug.Log("Subscribe1:" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe2:" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe3:" + msg));
        subject.OnNext("こんにちは");
        subject.OnNext("おはよう");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
