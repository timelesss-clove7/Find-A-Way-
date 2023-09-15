using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool isAlive = true;

    [Header("Values")]
    [SerializeField] float carSpeed;
    [SerializeField] float screenDelay;
    [SerializeField] float fadeConstant;
    [SerializeField] float superpowerDuration;
    [SerializeField] float diffrentialSuperpowerDuration;
    [SerializeField] float margainFromBottom;
    [SerializeField] Vector3 startPos = new Vector3(0, -1.3f, 1);

    [Header("Systems")]
    [SerializeField] ParticleSystem hitEffect;
    [SerializeField] float playerYPosition;
    [SerializeField] Button pauseButton;

    bool isInvisible = false;
    Rigidbody2D currentPlayerRigidbody;
    Vector2 moveInput;
    Camera mainCamera;
    Audiosource audiosource;
    Vector3 startPosWorld;
    Barectates barectates;
    Vector2 currentPosition = new Vector2();
    PrimarySystem primarySystem;
    [SerializeField] GameObject superPower;
    // Color color;
    // float minTime;
    // float maxTime;

    // void Awake()
    // {
    //     minTime = superpowerDuration - diffrentialSuperpowerDuration;
    //     maxTime = superpowerDuration + diffrentialSuperpowerDuration;
    // }

    void Start()
    {
        mainCamera = Camera.main;
        currentPlayerRigidbody = GetComponent<Rigidbody2D>();
        // color = this.GetComponent<SpriteRenderer>().color;
        primarySystem = FindObjectOfType<PrimarySystem>();
        audiosource = FindObjectOfType<Audiosource>();
        barectates = FindObjectOfType<Barectates>();
        transform.position = startPos;
        startPosWorld = mainCamera.WorldToScreenPoint(startPos);
        playerYPosition = startPosWorld.y;
    }

    void FixedUpdate()
    {
        CarMove();
        //FlipSprite();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
    void CarMove()
    {
        if (isAlive)
        {
            if (!Touchscreen.current.primaryTouch.press.isPressed)
            {
                currentPosition = transform.position;
                return;
            }

            if (Touchscreen.current.primaryTouch.press.isPressed)
            {
                Vector2 touchPosition = new Vector2(Touchscreen.current.primaryTouch.position.x.ReadValue(), playerYPosition);
                Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);
                if (worldPosition.x > -1.397f && worldPosition.y < 5.344f)
                {
                    currentPlayerRigidbody.position = worldPosition;
                }
                else
                {
                    currentPlayerRigidbody.position = transform.position;
                }
            }
        }
    }

    void FlipSprite()
    {

        bool isRight = false;
        bool isLeft = false;


        if (currentPosition.x < transform.position.x)
        {
            isLeft = true;
        }
        else if (currentPosition.x > transform.position.x)
        {
            isRight = true;
        }
        else if (currentPosition.x == transform.position.x)
        {
            isLeft = false;
            isRight = false;
        }

        if (isRight)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (isLeft)
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ObstaclesCombination" && isAlive && !isInvisible)
        {
            Die();
        }
    }

    void Die()
    {
        isAlive = false;
        audiosource.PlayCrashSoundEffect();
        PlayHitEffect();
        StartCoroutine(AfterLife());
    }

    IEnumerator AfterLife()
    {
        yield return new WaitForSeconds(screenDelay);
        pauseButton.enabled = false;
        primarySystem.LoseMenuSetup();
    }

    public void ContinueGame()
    {
        isAlive = true;
        pauseButton.enabled = true;
        primarySystem.LoseMenuDismantle();
    }

    public void Invinsible()
    {
        isInvisible = true;
        // color.a = fadeConstant;
        // this.GetComponent<SpriteRenderer>().color = color;
        // Invoke("ResetToNormal", UnityEngine.Random.Range(minTime, maxTime));
    }

    private void ResetToNormal()
    {
        isInvisible = false;
        // color.a = 1f;
        // this.GetComponent<SpriteRenderer>().color = color;
    }

    void PlayHitEffect()
    {
        if (hitEffect != null)
        {
            ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
            Debug.Log(primarySystem.currentScore);
        }
    }
}
