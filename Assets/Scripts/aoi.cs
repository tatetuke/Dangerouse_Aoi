using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aoi : MonoBehaviour
{

    SpriteRenderer MainSpriteRenderer;
    public GameController control;
    public Sprite[] aoiimage;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Change_Image();
    }

    /// <summary>
    /// 葵の画像切り替え
    /// </summary>
    public void Change_Image()
    {
        if (control.index == -1)
        {
            return;
            //Destroy(this.gameObject);
        }
        if (control.index < aoiimage.Length)
        {
            MainSpriteRenderer.sprite = aoiimage[control.index];
        }
    }

}
