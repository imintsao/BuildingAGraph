using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphImin : MonoBehaviour
{

    [SerializeField]
    Transform pointPrefab;

    void Awake()
    {
        //int i = 0;
        //while(i < 10)
        //    {
        //    i = i + 1;

        for (int i = 0; i<10; i++) { 
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * i;
            point.localScale = Vector3.one / 5f;
        }

        //Transform point = Instantitae(pointPrefab);

        //point = Instantiate(pointPrefab);
        //point.localPosition = Vector3.right * 2f;

    }

}


