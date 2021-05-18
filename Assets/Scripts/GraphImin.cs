using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphImin : MonoBehaviour
{

    [SerializeField]
    Transform pointPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] points; // add points field, and turn field into an array

    void Awake()
    {
        float step = 2f / resolution;
        //int i = 0;
        //while(i < 10)
        //    {
        //    i = i + 1;
        //Vector3 position;
        //var position = Vector3.zero;
        //var scale = Vector3.one / 5f;
        var scale = Vector3.one * step;
        var position = Vector3.zero;
        points = new Transform [resolution];
        for (int i = 0; i<points.Length; i++) { 
            Transform point = Instantiate(pointPrefab);
            //point.localPosition = Vector3.right * i;
            //point.localPosition = Vector3.right * i / 5f;
            //point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            //point.localScale = Vector3.one / 5f;
            //position.x = (i + 0.5f) / 5f - 1f;
            position.x = (i + 0.5f) * step - 1f;
            //position.y = position.x; //(becomes like a stair)
            //position.y = position.x * position.x; //(becomes like a curve)
            position.y = position.x * position.x * position.x; //why using Y?
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);
            points[i] = point;
        }

        //Transform point = Instantitae(pointPrefab);

        //point = Instantiate(pointPrefab);
        //point.localPosition = Vector3.right * 2f;

    }

    private void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            //position.y = position.x * position.x * position.x;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            point.localPosition = position;
        }
    }
}


