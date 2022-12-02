using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int span = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        span++;
        if (span >= 120) {
            transform.Translate(+0.5f, 0, 0);
            span = 0;
        }
    }
}
