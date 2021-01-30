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
        if (control.index == -1)
        {
            Destroy(this.gameObject);
        }
        MainSpriteRenderer.sprite = aoiimage[control.index];
    }
}
