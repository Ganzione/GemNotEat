using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0); //왼쪽으로 1만큼 움직
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0); //오른쪽으로 1만큼 움직
        }
    }
}
