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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(+0.5f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-0.5f, 0, 0);
        }
        
    }
}
