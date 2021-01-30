using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp;
    public int direction=-1;
    public bool shift = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

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
