using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SceneChanger
{

    public int hp;
    public int direction=-1;
    public bool shift = false;


    // Update is called once per frame
    void Update()
    {

        transform.localPosition = Utils.ClampPosition(transform.localPosition);
        input_key();
        transform_player();


    }
    void input_key()
    {
        shift = false;
        if (Input.GetMouseButtonDown(0))
        {
            direction *= -1;
        }
        if (Input.GetKey("left shift"))
        {
            shift = true;
        }
    }

    //被弾したときの処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "report") return;
        Debug.Log("当たり判定!");
        Destroy(collision.gameObject);
        hp--;
        if (hp == 0) GameOverScene();
     
    }

    //プレイヤーの移動
    void transform_player()
    {
        Transform myTransform = this.transform;
        if (shift)
        {
            if (direction == -1)
            {
                myTransform.Translate(0f, 0.02f, 0f, Space.World);
            }
            else
            {
                myTransform.Translate(0f, -0.02f, 0f, Space.World);
            }
        }
        else
        {
            if (direction == -1)
            {
                myTransform.Translate(0f, 0.06f, 0f, Space.World);
            }
            else
            {
                myTransform.Translate(0f, -0.06f, 0f, Space.World);
            }
        }


    }
}
