using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans : MonoBehaviour
{
    [SerializeField]
    GameObject marmite;
    public GameController talk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos= this.gameObject.transform.position;
        if (pos.x+1 >= 5f)
        {
            
            marmite.transform.Translate(-0.2f,0,0);
        }
    }
}
