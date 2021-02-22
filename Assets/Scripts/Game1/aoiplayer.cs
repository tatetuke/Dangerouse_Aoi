using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class aoiplayer : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    private void Update()
    {
        if (player.shift)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.65f);


        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

        }
    }
}
