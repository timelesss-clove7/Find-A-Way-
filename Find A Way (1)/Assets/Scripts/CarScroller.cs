using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScroller : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float moveSpeedMax;
    [SerializeField] float moveSpeedMin;
    float startPosY = -6;
    float endPos = 5.7f;
    void Start() 
    {
        transform.position = new Vector3(Random.Range(min, max), startPosY, 0);
    }

    void Update()
    {
        transform.Translate(0, Random.Range(moveSpeedMin, moveSpeedMax), 0);
        if(transform.position.y >= endPos)
        {
            transform.position = new Vector3(Random.Range(min, max), startPosY, 0);
        }
    }
}
