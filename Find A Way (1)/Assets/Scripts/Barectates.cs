using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barectates : MonoBehaviour
{
    public float moveSpeed;
    LooseCollider looseCollider;
    Player player;
    [SerializeField] float changeAmount = -0.01f;

    void Awake()
    {
        looseCollider = FindObjectOfType<LooseCollider>();
        player = FindObjectOfType<Player>();
    }

    void Start()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-looseCollider.value, looseCollider.value), transform.position.y, 0);
    }
    void Update()
    {
        if (player.isAlive)
        {
            moveSpeed += changeAmount * Time.deltaTime;
            transform.Translate(0, -(Time.deltaTime * moveSpeed), 0);
        }
    }
}
