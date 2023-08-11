using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LooseCollider : MonoBehaviour
{
    Player player;
    PrimarySystem primarySystem;
    [SerializeField] float launchPosY;
    float launchPosX;
    public float value = 1.1f;

    void Start()
    {
        primarySystem = FindObjectOfType<PrimarySystem>();
        player = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ObstaclesCombination")
        {
            if (player.isAlive)
            {
                primarySystem.IncreaseScore();
                launchPosX = Random.Range(-value, value);
                other.transform.position = new Vector3(
                    launchPosX,
                    launchPosY,
                    0);
            }
        }
    }
}
