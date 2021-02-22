using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameController control;
    public float speed;
    public Route route;
    private int pointIndex;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = route.points[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (control.index >= 1) transreport();
           
    }

    ///<summary>スプライトを移動させる</summary>
    private void transreport()
    {
        if (pointIndex < route.points.Length - 1)
        {//最後まで到達していない
            var v = route.points[pointIndex + 1].transform.position - route.points[pointIndex].transform.position;
            transform.position += v.normalized * speed * Time.deltaTime;

            var pv = transform.position - route.points[pointIndex].transform.position;
            if (pv.magnitude >= v.magnitude) pointIndex++;
        }
    }
}



